using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlockchainAssignment
{
    public partial class BlockchainApp : Form
    {
        Blockchain blockchain;
        public BlockchainApp()
        {
            InitializeComponent();
            blockchain = new Blockchain();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.ReadBlock(0);
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            blockchain.AddBlock(
            PublicKeybox.Text,
            MiningPreferenceBox.Text);
            richTextBox1.Text = blockchain.ReadBlock(blockchain.blocks.Count - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.ReadAllBlocks();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String privatekey;
            Wallet.Wallet Wallet = new Wallet.Wallet(out privatekey);

            PublicKeybox.Text = Wallet.publicID;
            PrivateKeybox.Text = privatekey;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            bool Valid = Wallet.Wallet.ValidatePrivateKey
                (
                  PrivateKeybox.Text,
                  PublicKeybox.Text
                );
            richTextBox1.Text = Valid ? "keys are correct" : "Keys are incorrect";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            double amount;
            double fee;

            if (!double.TryParse(Amountbox.Text, out amount))
            {
                richTextBox1.Text = "Invalid amount needs number ";
                return;

            }
            if(!double.TryParse(FeeBox.Text, out fee))
            {
                richTextBox1.Text = "Invalid amount or fee";
                return;
            }
            double balance = blockchain.GetBalance(PublicKeybox.Text);

            if(balance < amount + fee)
            {
                richTextBox1.Text = "Insufficient balance";
                return;
            }
            Transaction transaction = new Transaction 
                (
                PublicKeybox.Text,
                RecieverBox.Text,
                amount,
                fee,
                "",
                PrivateKeybox.Text
                 );
            blockchain.AddTransaction(transaction);
            richTextBox1.Text = "Transaction added to pool"+transaction.ReadTransaction();
        }

        private void RecieverAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.ReadTransactionPool();
        }

        private void ValidateChainBox_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = blockchain.ValidateChain();
        }

        private void TamperBlockBox_Click(object sender, EventArgs e)
        {
            if (blockchain.blocks.Count > 1)
            {
                blockchain.blocks[1].PreviousHash = "fake hash";
                richTextBox1.Text= "Block 1 has been tampered with"; 
            }
            else
            {
                richTextBox1.Text = "add one block first";
            }
        }

        private void CheckBalanceBox_Click(object sender, EventArgs e)
        {
            double balance = blockchain.GetBalance(PublicKeybox.Text);

            richTextBox1.Text = "Balance: " + balance;
        }

        private void MiningPreferenceBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            blockchain.UseMultithreading = false;

            blockchain.AddBlock(
                PublicKeybox.Text,
                MiningPreferenceBox.Text
            );

            richTextBox1.Text = blockchain.ReadBlock(blockchain.blocks.Count - 1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            blockchain.UseMultithreading = true;

            blockchain.AddBlock(
                PublicKeybox.Text,
                MiningPreferenceBox.Text
            );

            richTextBox1.Text = blockchain.ReadBlock(blockchain.blocks.Count - 1);
        }
    }

}
