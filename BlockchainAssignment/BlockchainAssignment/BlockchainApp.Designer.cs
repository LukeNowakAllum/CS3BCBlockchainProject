namespace BlockchainAssignment
{
    partial class BlockchainApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.PublicKeybox = new System.Windows.Forms.TextBox();
            this.PrivateKeybox = new System.Windows.Forms.TextBox();
            this.FeeBox = new System.Windows.Forms.TextBox();
            this.Amountbox = new System.Windows.Forms.TextBox();
            this.RecieverBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.ValidateChainBox = new System.Windows.Forms.Button();
            this.TamperBlockBox = new System.Windows.Forms.Button();
            this.CheckBalanceBox = new System.Windows.Forms.Button();
            this.MiningPreferenceBox = new System.Windows.Forms.ComboBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.InfoText;
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richTextBox1.Location = new System.Drawing.Point(36, 52);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(665, 328);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter to console ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(35, 386);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(184, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "Write console commands here";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(272, 386);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "add block";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(272, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Read all blocks";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(480, 386);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "generate wallet";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(480, 415);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(104, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "validateKeys";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // PublicKeybox
            // 
            this.PublicKeybox.Location = new System.Drawing.Point(601, 386);
            this.PublicKeybox.Name = "PublicKeybox";
            this.PublicKeybox.Size = new System.Drawing.Size(180, 20);
            this.PublicKeybox.TabIndex = 7;
            this.PublicKeybox.Text = "public key";
            // 
            // PrivateKeybox
            // 
            this.PrivateKeybox.Location = new System.Drawing.Point(601, 415);
            this.PrivateKeybox.Name = "PrivateKeybox";
            this.PrivateKeybox.Size = new System.Drawing.Size(180, 20);
            this.PrivateKeybox.TabIndex = 8;
            this.PrivateKeybox.Text = "private key";
            // 
            // FeeBox
            // 
            this.FeeBox.Location = new System.Drawing.Point(601, 548);
            this.FeeBox.Name = "FeeBox";
            this.FeeBox.Size = new System.Drawing.Size(84, 20);
            this.FeeBox.TabIndex = 9;
            this.FeeBox.Text = "fee";
            // 
            // Amountbox
            // 
            this.Amountbox.Location = new System.Drawing.Point(601, 513);
            this.Amountbox.Name = "Amountbox";
            this.Amountbox.Size = new System.Drawing.Size(100, 20);
            this.Amountbox.TabIndex = 10;
            this.Amountbox.Text = "Amount";
            this.Amountbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // RecieverBox
            // 
            this.RecieverBox.Location = new System.Drawing.Point(601, 487);
            this.RecieverBox.Name = "RecieverBox";
            this.RecieverBox.Size = new System.Drawing.Size(158, 20);
            this.RecieverBox.TabIndex = 11;
            this.RecieverBox.Text = "Reciever adress";
            this.RecieverBox.TextChanged += new System.EventHandler(this.RecieverAdress_TextChanged);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(448, 487);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Create Transaction";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(448, 526);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(119, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Read Pending";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // ValidateChainBox
            // 
            this.ValidateChainBox.Location = new System.Drawing.Point(51, 475);
            this.ValidateChainBox.Name = "ValidateChainBox";
            this.ValidateChainBox.Size = new System.Drawing.Size(146, 46);
            this.ValidateChainBox.TabIndex = 14;
            this.ValidateChainBox.Text = "Validate Chain";
            this.ValidateChainBox.UseVisualStyleBackColor = true;
            this.ValidateChainBox.Click += new System.EventHandler(this.ValidateChainBox_Click);
            // 
            // TamperBlockBox
            // 
            this.TamperBlockBox.Location = new System.Drawing.Point(258, 475);
            this.TamperBlockBox.Name = "TamperBlockBox";
            this.TamperBlockBox.Size = new System.Drawing.Size(109, 46);
            this.TamperBlockBox.TabIndex = 15;
            this.TamperBlockBox.Text = "TamperBlock";
            this.TamperBlockBox.UseVisualStyleBackColor = true;
            this.TamperBlockBox.Click += new System.EventHandler(this.TamperBlockBox_Click);
            // 
            // CheckBalanceBox
            // 
            this.CheckBalanceBox.Location = new System.Drawing.Point(258, 548);
            this.CheckBalanceBox.Name = "CheckBalanceBox";
            this.CheckBalanceBox.Size = new System.Drawing.Size(109, 44);
            this.CheckBalanceBox.TabIndex = 16;
            this.CheckBalanceBox.Text = "Check Balance button";
            this.CheckBalanceBox.UseVisualStyleBackColor = true;
            this.CheckBalanceBox.Click += new System.EventHandler(this.CheckBalanceBox_Click);
            // 
            // MiningPreferenceBox
            // 
            this.MiningPreferenceBox.FormattingEnabled = true;
            this.MiningPreferenceBox.Items.AddRange(new object[] {
            "Greedy",
            "",
            "Altruistic",
            "",
            "Random",
            "",
            "Address ",
            "Preference"});
            this.MiningPreferenceBox.Location = new System.Drawing.Point(35, 547);
            this.MiningPreferenceBox.Name = "MiningPreferenceBox";
            this.MiningPreferenceBox.Size = new System.Drawing.Size(184, 21);
            this.MiningPreferenceBox.TabIndex = 17;
            this.MiningPreferenceBox.Text = "Greedy";
            this.MiningPreferenceBox.SelectedIndexChanged += new System.EventHandler(this.MiningPreferenceBox_SelectedIndexChanged);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(730, 201);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(114, 23);
            this.button8.TabIndex = 18;
            this.button8.Text = "mine single thread";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(733, 241);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(111, 23);
            this.button9.TabIndex = 19;
            this.button9.Text = "Mine Multi Thread";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // BlockchainApp
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(866, 604);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.MiningPreferenceBox);
            this.Controls.Add(this.CheckBalanceBox);
            this.Controls.Add(this.TamperBlockBox);
            this.Controls.Add(this.ValidateChainBox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.RecieverBox);
            this.Controls.Add(this.Amountbox);
            this.Controls.Add(this.FeeBox);
            this.Controls.Add(this.PrivateKeybox);
            this.Controls.Add(this.PublicKeybox);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "BlockchainApp";
            this.Tag = "Greedy\nAltruistic\nRandom\nAddress Preference";
            this.Text = "Greedy";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox PublicKeybox;
        private System.Windows.Forms.TextBox PrivateKeybox;
        private System.Windows.Forms.TextBox FeeBox;
        private System.Windows.Forms.TextBox Amountbox;
        private System.Windows.Forms.TextBox RecieverBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button ValidateChainBox;
        private System.Windows.Forms.Button TamperBlockBox;
        private System.Windows.Forms.Button CheckBalanceBox;
        private System.Windows.Forms.ComboBox MiningPreferenceBox;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

