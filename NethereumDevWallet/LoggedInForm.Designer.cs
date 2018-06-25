namespace NethereumDevWallet
{
    partial class LoggedInForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hashAndReceiptTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sentTransactionHashTextBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sentTransactionDataTextBox = new System.Windows.Forms.RichTextBox();
            this.sendEthTransactionButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.gasUsedToUseTextBox = new System.Windows.Forms.MaskedTextBox();
            this.gasPriceToUseTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ethToSendTextBox = new System.Windows.Forms.MaskedTextBox();
            this.receipientAddressTextBox = new System.Windows.Forms.MaskedTextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.drainSendButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.drainSignedTransactionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.drainTransactionReceiptRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.drainTransactionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.drainReceipientAddressTextBox = new System.Windows.Forms.MaskedTextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.networkTextBox = new System.Windows.Forms.TextBox();
            this.balanceTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.logoutButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.gasPriceTextBox = new System.Windows.Forms.TextBox();
            this.refreshGasPriceButton = new System.Windows.Forms.Button();
            this.refreshBalanceButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 152);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 387);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.Controls.Add(this.hashAndReceiptTextBox);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.sentTransactionDataTextBox);
            this.tabPage1.Controls.Add(this.sendEthTransactionButton);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.gasUsedToUseTextBox);
            this.tabPage1.Controls.Add(this.gasPriceToUseTextBox);
            this.tabPage1.Controls.Add(this.ethToSendTextBox);
            this.tabPage1.Controls.Add(this.receipientAddressTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 361);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Send";
            // 
            // hashAndReceiptTextBox
            // 
            this.hashAndReceiptTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.hashAndReceiptTextBox.Location = new System.Drawing.Point(409, 156);
            this.hashAndReceiptTextBox.Name = "hashAndReceiptTextBox";
            this.hashAndReceiptTextBox.ReadOnly = true;
            this.hashAndReceiptTextBox.Size = new System.Drawing.Size(342, 185);
            this.hashAndReceiptTextBox.TabIndex = 12;
            this.hashAndReceiptTextBox.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sentTransactionHashTextBox);
            this.panel1.Location = new System.Drawing.Point(16, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 110);
            this.panel1.TabIndex = 11;
            // 
            // sentTransactionHashTextBox
            // 
            this.sentTransactionHashTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sentTransactionHashTextBox.Location = new System.Drawing.Point(3, 3);
            this.sentTransactionHashTextBox.Name = "sentTransactionHashTextBox";
            this.sentTransactionHashTextBox.ReadOnly = true;
            this.sentTransactionHashTextBox.Size = new System.Drawing.Size(326, 104);
            this.sentTransactionHashTextBox.TabIndex = 0;
            this.sentTransactionHashTextBox.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(406, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Transaction";
            // 
            // sentTransactionDataTextBox
            // 
            this.sentTransactionDataTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sentTransactionDataTextBox.Location = new System.Drawing.Point(409, 33);
            this.sentTransactionDataTextBox.Name = "sentTransactionDataTextBox";
            this.sentTransactionDataTextBox.ReadOnly = true;
            this.sentTransactionDataTextBox.Size = new System.Drawing.Size(342, 116);
            this.sentTransactionDataTextBox.TabIndex = 9;
            this.sentTransactionDataTextBox.Text = "";
            // 
            // sendEthTransactionButton
            // 
            this.sendEthTransactionButton.Location = new System.Drawing.Point(123, 181);
            this.sendEthTransactionButton.Name = "sendEthTransactionButton";
            this.sendEthTransactionButton.Size = new System.Drawing.Size(213, 31);
            this.sendEthTransactionButton.TabIndex = 8;
            this.sendEthTransactionButton.Text = "Send";
            this.sendEthTransactionButton.UseVisualStyleBackColor = true;
            this.sendEthTransactionButton.Click += new System.EventHandler(this.sendEthTransactionButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Gas Used";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Gas Price (Gwei)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Amount (Eth)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Receipient Address";
            // 
            // gasUsedToUseTextBox
            // 
            this.gasUsedToUseTextBox.Location = new System.Drawing.Point(123, 133);
            this.gasUsedToUseTextBox.Name = "gasUsedToUseTextBox";
            this.gasUsedToUseTextBox.Size = new System.Drawing.Size(213, 20);
            this.gasUsedToUseTextBox.TabIndex = 3;
            // 
            // gasPriceToUseTextBox
            // 
            this.gasPriceToUseTextBox.Location = new System.Drawing.Point(123, 92);
            this.gasPriceToUseTextBox.Name = "gasPriceToUseTextBox";
            this.gasPriceToUseTextBox.Size = new System.Drawing.Size(213, 20);
            this.gasPriceToUseTextBox.TabIndex = 2;
            // 
            // ethToSendTextBox
            // 
            this.ethToSendTextBox.Location = new System.Drawing.Point(123, 51);
            this.ethToSendTextBox.Name = "ethToSendTextBox";
            this.ethToSendTextBox.Size = new System.Drawing.Size(213, 20);
            this.ethToSendTextBox.TabIndex = 1;
            // 
            // receipientAddressTextBox
            // 
            this.receipientAddressTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.receipientAddressTextBox.Location = new System.Drawing.Point(123, 6);
            this.receipientAddressTextBox.Name = "receipientAddressTextBox";
            this.receipientAddressTextBox.Size = new System.Drawing.Size(213, 20);
            this.receipientAddressTextBox.TabIndex = 0;
            this.receipientAddressTextBox.TextChanged += new System.EventHandler(this.PrepareSendTransaction);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.drainSendButton);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.drainTransactionReceiptRichTextBox);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.drainTransactionRichTextBox);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.drainReceipientAddressTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 361);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Drain";
            // 
            // drainSendButton
            // 
            this.drainSendButton.Location = new System.Drawing.Point(123, 149);
            this.drainSendButton.Name = "drainSendButton";
            this.drainSendButton.Size = new System.Drawing.Size(213, 31);
            this.drainSendButton.TabIndex = 17;
            this.drainSendButton.Text = "Generate && Send";
            this.drainSendButton.UseVisualStyleBackColor = true;
            this.drainSendButton.Click += new System.EventHandler(this.drainSendButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.drainSignedTransactionRichTextBox);
            this.panel2.Location = new System.Drawing.Point(15, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(332, 110);
            this.panel2.TabIndex = 16;
            // 
            // drainSignedTransactionRichTextBox
            // 
            this.drainSignedTransactionRichTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.drainSignedTransactionRichTextBox.Location = new System.Drawing.Point(3, 3);
            this.drainSignedTransactionRichTextBox.Name = "drainSignedTransactionRichTextBox";
            this.drainSignedTransactionRichTextBox.ReadOnly = true;
            this.drainSignedTransactionRichTextBox.Size = new System.Drawing.Size(326, 104);
            this.drainSignedTransactionRichTextBox.TabIndex = 0;
            this.drainSignedTransactionRichTextBox.Text = "";
            // 
            // drainTransactionReceiptRichTextBox
            // 
            this.drainTransactionReceiptRichTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.drainTransactionReceiptRichTextBox.Location = new System.Drawing.Point(420, 149);
            this.drainTransactionReceiptRichTextBox.Name = "drainTransactionReceiptRichTextBox";
            this.drainTransactionReceiptRichTextBox.ReadOnly = true;
            this.drainTransactionReceiptRichTextBox.Size = new System.Drawing.Size(342, 185);
            this.drainTransactionReceiptRichTextBox.TabIndex = 15;
            this.drainTransactionReceiptRichTextBox.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Transaction";
            // 
            // drainTransactionRichTextBox
            // 
            this.drainTransactionRichTextBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.drainTransactionRichTextBox.Location = new System.Drawing.Point(420, 26);
            this.drainTransactionRichTextBox.Name = "drainTransactionRichTextBox";
            this.drainTransactionRichTextBox.ReadOnly = true;
            this.drainTransactionRichTextBox.Size = new System.Drawing.Size(342, 116);
            this.drainTransactionRichTextBox.TabIndex = 13;
            this.drainTransactionRichTextBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Receipient Address";
            // 
            // drainReceipientAddressTextBox
            // 
            this.drainReceipientAddressTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.drainReceipientAddressTextBox.Location = new System.Drawing.Point(123, 6);
            this.drainReceipientAddressTextBox.Name = "drainReceipientAddressTextBox";
            this.drainReceipientAddressTextBox.Size = new System.Drawing.Size(213, 20);
            this.drainReceipientAddressTextBox.TabIndex = 5;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(66, 12);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.ReadOnly = true;
            this.addressTextBox.Size = new System.Drawing.Size(295, 20);
            this.addressTextBox.TabIndex = 1;
            // 
            // networkTextBox
            // 
            this.networkTextBox.Location = new System.Drawing.Point(425, 12);
            this.networkTextBox.Name = "networkTextBox";
            this.networkTextBox.ReadOnly = true;
            this.networkTextBox.Size = new System.Drawing.Size(167, 20);
            this.networkTextBox.TabIndex = 2;
            // 
            // balanceTextBox
            // 
            this.balanceTextBox.Location = new System.Drawing.Point(90, 41);
            this.balanceTextBox.Name = "balanceTextBox";
            this.balanceTextBox.ReadOnly = true;
            this.balanceTextBox.Size = new System.Drawing.Size(262, 20);
            this.balanceTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Balance (Eth)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Network";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address";
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(617, 10);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(167, 23);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gas Price (Gwei)";
            // 
            // gasPriceTextBox
            // 
            this.gasPriceTextBox.Location = new System.Drawing.Point(105, 69);
            this.gasPriceTextBox.Name = "gasPriceTextBox";
            this.gasPriceTextBox.ReadOnly = true;
            this.gasPriceTextBox.Size = new System.Drawing.Size(247, 20);
            this.gasPriceTextBox.TabIndex = 8;
            // 
            // refreshGasPriceButton
            // 
            this.refreshGasPriceButton.Location = new System.Drawing.Point(359, 67);
            this.refreshGasPriceButton.Name = "refreshGasPriceButton";
            this.refreshGasPriceButton.Size = new System.Drawing.Size(75, 23);
            this.refreshGasPriceButton.TabIndex = 9;
            this.refreshGasPriceButton.Text = "Refresh";
            this.refreshGasPriceButton.UseVisualStyleBackColor = true;
            this.refreshGasPriceButton.Click += new System.EventHandler(this.refreshGasPriceButton_Click);
            // 
            // refreshBalanceButton
            // 
            this.refreshBalanceButton.Location = new System.Drawing.Point(359, 38);
            this.refreshBalanceButton.Name = "refreshBalanceButton";
            this.refreshBalanceButton.Size = new System.Drawing.Size(75, 23);
            this.refreshBalanceButton.TabIndex = 10;
            this.refreshBalanceButton.Text = "Refresh";
            this.refreshBalanceButton.UseVisualStyleBackColor = true;
            this.refreshBalanceButton.Click += new System.EventHandler(this.refreshBalanceButton_Click);
            // 
            // LoggedInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 577);
            this.Controls.Add(this.refreshBalanceButton);
            this.Controls.Add(this.refreshGasPriceButton);
            this.Controls.Add(this.gasPriceTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.balanceTextBox);
            this.Controls.Add(this.networkTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.tabControl1);
            this.Name = "LoggedInForm";
            this.Text = "Ethereum Dev Wallet";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox networkTextBox;
        private System.Windows.Forms.TextBox balanceTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gasPriceTextBox;
        private System.Windows.Forms.Button refreshGasPriceButton;
        private System.Windows.Forms.Button refreshBalanceButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox gasUsedToUseTextBox;
        private System.Windows.Forms.MaskedTextBox gasPriceToUseTextBox;
        private System.Windows.Forms.MaskedTextBox ethToSendTextBox;
        private System.Windows.Forms.MaskedTextBox receipientAddressTextBox;
        private System.Windows.Forms.Button sendEthTransactionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox sentTransactionHashTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox sentTransactionDataTextBox;
        private System.Windows.Forms.RichTextBox hashAndReceiptTextBox;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button drainSendButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox drainSignedTransactionRichTextBox;
        private System.Windows.Forms.RichTextBox drainTransactionReceiptRichTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox drainTransactionRichTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox drainReceipientAddressTextBox;
    }
}