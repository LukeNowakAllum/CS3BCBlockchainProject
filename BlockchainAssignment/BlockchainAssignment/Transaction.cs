using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockchainAssignment
{
    internal class Transaction
    {
        public string Hash;
        public string Signature;
        public string SenderAdress;
        public string RecieverAdress;
        public DateTime ts;
        public double Amount;
        public double Fee;

        public Transaction(string sender, string reciever, double amount, double fees, string signature, string privateKey)
        {
            SenderAdress = sender;
            RecieverAdress = reciever;
            Amount = amount;
            Fee = fees;
            Signature = signature;
            ts = DateTime.Now;

            Hash = CreateHash();

            if (sender =="mine Rewards ")
            {
                Signature = "";
            }
            else
            {
                Signature = Wallet.Wallet.CreateSignature(sender, privateKey, Hash);
            }
        }
        public string CreateHash()
        {
            SHA256 Hasher = SHA256Managed.Create();
            String input = SenderAdress + RecieverAdress + Amount.ToString() + Fee.ToString() + ts.ToString();
            byte[] Hashbyte = Hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
            string output = "";
            foreach (byte b in Hashbyte)
            {
                output += String.Format("{0:x2}", b);
            }
            return output;
        }
        public string ReadTransaction()
        {
            return "Sender: " + SenderAdress
                + "\nReciever: " + RecieverAdress
                + "\nAmount: " + Amount
                + "\nFee: " + Fee
                + "\nHash: " + Hash
                + "\nSignature: " + Signature
                + "\nTimestamp: " + ts;
        }
    }
}
