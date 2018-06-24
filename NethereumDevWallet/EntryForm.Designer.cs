namespace NethereumDevWallet
{
    partial class EntryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EntryForm));
            this.jsonButton = new System.Windows.Forms.Button();
            this.mnemonicsButton = new System.Windows.Forms.Button();
            this.privateKeyButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serverDropdownList = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // jsonButton
            // 
            this.jsonButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.jsonButton.Location = new System.Drawing.Point(184, 297);
            this.jsonButton.Name = "jsonButton";
            this.jsonButton.Size = new System.Drawing.Size(109, 42);
            this.jsonButton.TabIndex = 0;
            this.jsonButton.Text = "JSON File";
            this.jsonButton.UseVisualStyleBackColor = true;
            this.jsonButton.Click += new System.EventHandler(this.jsonButton_Click);
            // 
            // mnemonicsButton
            // 
            this.mnemonicsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mnemonicsButton.Location = new System.Drawing.Point(350, 297);
            this.mnemonicsButton.Name = "mnemonicsButton";
            this.mnemonicsButton.Size = new System.Drawing.Size(109, 42);
            this.mnemonicsButton.TabIndex = 1;
            this.mnemonicsButton.Text = "Mnemonics";
            this.mnemonicsButton.UseVisualStyleBackColor = true;
            this.mnemonicsButton.Click += new System.EventHandler(this.mnemonicsButton_Click);
            // 
            // privateKeyButton
            // 
            this.privateKeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.privateKeyButton.Location = new System.Drawing.Point(533, 297);
            this.privateKeyButton.Name = "privateKeyButton";
            this.privateKeyButton.Size = new System.Drawing.Size(111, 42);
            this.privateKeyButton.TabIndex = 2;
            this.privateKeyButton.Text = "Private Key";
            this.privateKeyButton.UseVisualStyleBackColor = true;
            this.privateKeyButton.Click += new System.EventHandler(this.privateKeyButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NethereumDevWallet.Properties.Resources.doge;
            this.pictureBox1.Location = new System.Drawing.Point(294, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 195);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // serverDropdownList
            // 
            this.serverDropdownList.FormattingEnabled = true;
            this.serverDropdownList.Location = new System.Drawing.Point(584, 13);
            this.serverDropdownList.Name = "serverDropdownList";
            this.serverDropdownList.Size = new System.Drawing.Size(121, 21);
            this.serverDropdownList.TabIndex = 4;
            this.serverDropdownList.SelectedIndexChanged += new System.EventHandler(this.serverDropdownList_SelectedIndexChanged);
            // 
            // EntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.serverDropdownList);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.privateKeyButton);
            this.Controls.Add(this.mnemonicsButton);
            this.Controls.Add(this.jsonButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EntryForm";
            this.Text = "Ethereum Dev Wallet";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button jsonButton;
        private System.Windows.Forms.Button mnemonicsButton;
        private System.Windows.Forms.Button privateKeyButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox serverDropdownList;
    }
}

