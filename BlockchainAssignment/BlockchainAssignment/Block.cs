using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BlockchainAssignment
{
    class Block
    {
        public double SingleThreadMiningTime;
        public int ThreadCount = 4;
        public double MultiThreadMiningTime;
        public double MiningTime;
        public string MerkleRoot;
        public double Reward = 25;
        public double Fees = 0;
        public string MinerAddress;
        public int Nonce = 0;
        public int Difficulty = 4;
        public List<Transaction> Transactions = new List<Transaction>();

        public DateTime ts;

        public int i;
        public string Hash;
        public string PreviousHash;
        public Block()
        {
            PreviousHash = "";
            i = 0;
            ts = DateTime.Now;

            Hash = CreateHash();
        }
        public Block(string previousHash, int PreviousI, List<Transaction> transactions, string minerAddress ,bool useMultithreading)
        {
            PreviousHash = previousHash;
            i = PreviousI + 1;
            ts = DateTime.Now;
            this.Transactions = transactions;

            MinerAddress = minerAddress;

            AddRewardTransaction();
            MerkleRoot = CalculateMerkleRoot();

            Hash = CreateHash();
            if (useMultithreading)
            {
                MineMultiThreaded();
            }
            else
            {
                mine();
            }
            AdjustDifficulty();

        }
        public string CreateHash()
        {
            SHA256 Hasher = SHA256Managed.Create();
            string input = i.ToString() + PreviousHash + ts.ToString() + Nonce.ToString() + Difficulty.ToString() + MerkleRoot;

            byte[] HashByte = Hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            String Output = "";

            foreach (byte b in HashByte)
            {
                Output += String.Format("{0:x2}", b);
            }
            return Output;

        }
        public void mine()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string target = new string('0', Difficulty);

            while (!Hash.StartsWith(target))
            {
                Nonce++;
                Hash = CreateHash();
            }

            stopwatch.Stop();
            SingleThreadMiningTime = stopwatch.Elapsed.TotalSeconds;
        }
        public string ReadBlock()
        {
            string output =
                "Block: " + i
                + "\nHash: " + Hash
                + "\nPrevious Hash: " + PreviousHash
                + "\nTimestamp: " + ts
                + "\nTransactions:"
                +"\nMerkle Root: " + MerkleRoot
                + "\nMining Time: " + MiningTime + " seconds"
                + "\nMultithread Mining Time: " + MultiThreadMiningTime + " seconds"
                + "\nSingle-thread Mining Time: " + SingleThreadMiningTime + " seconds"
                + "\nMultithread Mining Time: " + MultiThreadMiningTime + " seconds";
            foreach (Transaction t in Transactions)
            {
                output += "\n\n" + t.ReadTransaction();
            }
            return output;
        }
        public void AddRewardTransaction()
        {
            foreach (Transaction t in Transactions)
            {
                Fees += t.Fee;
            }
            Transaction RewardTransaction = new Transaction
                (
                "Mine Rewards",
                MinerAddress,
                Reward + Fees,
                0,
                "",
                ""
                );
            Transactions.Add(RewardTransaction);
        }
        public void AdjustDifficulty()
        {
            if (MiningTime < 3)
            {
                Difficulty++;
            }
            else if (MiningTime > 3)
            {
                Difficulty--;
            }

            if (Difficulty < 1)
            {
                Difficulty = 1;
            }
        }
        public string CalculateMerkleRoot()
        {
            if (Transactions.Count == 0)
            {
                return "";

            }
            List<string> hashes = new List<string>();
            foreach (Transaction t in Transactions)
            {
                hashes.Add(t.Hash);
            }
            while (hashes.Count > 1)
            {
                List<string> NewHashes = new List<string>();
                for (int i = 0; i < hashes.Count; i += 2)
                {
                    if (i + 1 < hashes.Count)
                    {
                        NewHashes.Add(hashes[i] + hashes[i + 1]);
                    }
                    else
                    {
                        NewHashes.Add(hashes[i]);
                    }
                    
                }
                hashes = NewHashes;
            }
            return hashes[0];
        }
        public void MineMultiThreaded()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            bool found = false;
            object lockObject = new object();
            string target = new string('0', Difficulty);

            System.Threading.Tasks.Parallel.For(0, ThreadCount, (threadId, state) =>
            {
                int localNonce = threadId;

                while (!found)
                {
                    Nonce = localNonce;
                    string localHash = CreateHash();

                    if (localHash.StartsWith(target))
                    {
                        lock (lockObject)
                        {
                            if (!found)
                            {
                                found = true;
                                Nonce = localNonce;
                                Hash = localHash;
                                state.Stop();
                            }
                        }
                    }

                    localNonce += ThreadCount;
                }
            });

            stopwatch.Stop();
            MultiThreadMiningTime = stopwatch.Elapsed.TotalSeconds;
        }
    }
}
