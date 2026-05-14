using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    class Blockchain
    {
        public bool UseMultithreading = false;
        public List<Transaction> TransactionPool = new List<Transaction>();
        public List<Block>blocks= new List <Block>();
        public Blockchain()
        {
            blocks.Add(new Block());
        }
        public Block GetLastBlock()
        {
            return blocks[blocks.Count - 1];

        }
        public void AddBlock(string minerAddress, string preference)
        {
            Block lastBlock = GetLastBlock();
            List<Transaction> ChosenTransactions;

            switch (preference)
            {
                case "Greedy":
                    ChosenTransactions = TransactionPool
                        .OrderByDescending(t => t.Fee)
                        .Take(5)
                        .ToList();
                    break;

                case "Altruistic":
                    ChosenTransactions = TransactionPool
                        .OrderBy(t => t.ts)
                        .Take(5)
                        .ToList();
                    break;

                case "Random":
                    ChosenTransactions = TransactionPool
                        .OrderBy(t => Guid.NewGuid())
                        .Take(5)
                        .ToList();
                    break;

                case "Address Preference":
                    ChosenTransactions = TransactionPool
                        .OrderByDescending(t =>
                            t.SenderAdress == minerAddress ||
                            t.RecieverAdress == minerAddress)
                        .Take(5)
                        .ToList();
                    break;

                default:
                    ChosenTransactions = TransactionPool
                        .Take(5)
                        .ToList();
                    break;
            }
            Block NewBlock= new Block ( lastBlock.Hash,lastBlock.i, ChosenTransactions, minerAddress, UseMultithreading);

            blocks.Add(NewBlock);
            TransactionPool =TransactionPool.Except(ChosenTransactions).ToList();
        }
        public string ReadBlock(int i)
        {
            return blocks[i].ReadBlock();
        }
        public string ReadAllBlocks()
        {
            string output = "";
            foreach (Block b in blocks)
            {
                output += b.ReadBlock() + "\n\n";
            }
            return output;
        }
        public void AddTransaction(Transaction transaction)
        {
            TransactionPool.Add(transaction);
        }
        public string ReadTransactionPool()
        {
            string output = "";
            foreach (Transaction t in TransactionPool)
            {
                output += t.ReadTransaction() + "\n\n";
            }
            if (output =="")
            {
                output = "no pending transaction";
            }
            return output;
        }
        public string ValidateChain()
        {
            for (int i = 1; i < blocks.Count; i++)
            {
                Block currentBlock = blocks[i];
                Block previousBlock = blocks[i - 1];
                if (currentBlock.PreviousHash != previousBlock.Hash)
                {
                    return "Blockchain is invalid at block " + i;
                }
                if (currentBlock.Hash != currentBlock.CreateHash())
                {
                    return "Blockchain is invalid at block " + i;
                }
                if (currentBlock.MerkleRoot != currentBlock.CalculateMerkleRoot())
                {
                    return "Block " + i + " Merkle Root invalid.";
                }
                foreach (Transaction t in currentBlock.Transactions)
                {
                    if (t.Hash != t.CreateHash())
                    {
                        return "Transaction hash invalid.";
                    }
                    if (t.SenderAdress != "Mine Rewards")
                    {
                        bool validSignature =
                            Wallet.Wallet.ValidateSignature(
                                t.SenderAdress,
                                t.Hash,
                                t.Signature
                            );

                        if (!validSignature)
                        {
                            return "Invalid transaction signature.";
                        }
                    }
                }
                
            }
            return "Blockchain is valid";
        }
        public double GetBalance(string adress)
        {
            double balance = 0;
            foreach(Block block in blocks)
            {
               foreach (Transaction transaction in block.Transactions)
                {
                    if (transaction.RecieverAdress== adress)
                    {
                        balance += transaction.Amount;
                    }
                    if (transaction.SenderAdress == adress)
                    {
                        balance -= transaction.Amount;
                        balance -= transaction.Fee;
                    }

                }
            }
            return balance;
        }
    }
}
