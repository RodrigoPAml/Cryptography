namespace CriptoForms
{
    partial class CryptoForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.textBoxPrivateKey = new System.Windows.Forms.TextBox();
            this.textBoxPublicKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioRSABtn = new System.Windows.Forms.RadioButton();
            this.radioAESBtn = new System.Windows.Forms.RadioButton();
            this.textBoxPlainText = new System.Windows.Forms.TextBox();
            this.textBoxEncryptedText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.checkBoxEncrypt = new System.Windows.Forms.CheckBox();
            this.checkBoxDecrypt = new System.Windows.Forms.CheckBox();
            this.textBoxIV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(681, 42);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(75, 63);
            this.buttonGenerate.TabIndex = 0;
            this.buttonGenerate.Text = "Generate Keys";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click_1);
            // 
            // textBoxPrivateKey
            // 
            this.textBoxPrivateKey.Enabled = false;
            this.textBoxPrivateKey.Location = new System.Drawing.Point(93, 42);
            this.textBoxPrivateKey.Name = "textBoxPrivateKey";
            this.textBoxPrivateKey.Size = new System.Drawing.Size(567, 23);
            this.textBoxPrivateKey.TabIndex = 1;
            // 
            // textBoxPublicKey
            // 
            this.textBoxPublicKey.Enabled = false;
            this.textBoxPublicKey.Location = new System.Drawing.Point(93, 95);
            this.textBoxPublicKey.Name = "textBoxPublicKey";
            this.textBoxPublicKey.Size = new System.Drawing.Size(567, 23);
            this.textBoxPublicKey.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Private Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Public Key";
            // 
            // radioRSABtn
            // 
            this.radioRSABtn.AutoSize = true;
            this.radioRSABtn.Location = new System.Drawing.Point(13, 9);
            this.radioRSABtn.Name = "radioRSABtn";
            this.radioRSABtn.Size = new System.Drawing.Size(73, 19);
            this.radioRSABtn.TabIndex = 5;
            this.radioRSABtn.TabStop = true;
            this.radioRSABtn.Text = "RSA 2048";
            this.radioRSABtn.UseVisualStyleBackColor = true;
            this.radioRSABtn.CheckedChanged += new System.EventHandler(this.radioRSABtn_CheckedChanged);
            // 
            // radioAESBtn
            // 
            this.radioAESBtn.AutoSize = true;
            this.radioAESBtn.Location = new System.Drawing.Point(89, 9);
            this.radioAESBtn.Name = "radioAESBtn";
            this.radioAESBtn.Size = new System.Drawing.Size(66, 19);
            this.radioAESBtn.TabIndex = 6;
            this.radioAESBtn.TabStop = true;
            this.radioAESBtn.Text = "AES 256";
            this.radioAESBtn.UseVisualStyleBackColor = true;
            this.radioAESBtn.CheckedChanged += new System.EventHandler(this.radioAESBtn_CheckedChanged);
            // 
            // textBoxPlainText
            // 
            this.textBoxPlainText.Location = new System.Drawing.Point(14, 156);
            this.textBoxPlainText.Multiline = true;
            this.textBoxPlainText.Name = "textBoxPlainText";
            this.textBoxPlainText.Size = new System.Drawing.Size(368, 256);
            this.textBoxPlainText.TabIndex = 7;
            // 
            // textBoxEncryptedText
            // 
            this.textBoxEncryptedText.Location = new System.Drawing.Point(409, 153);
            this.textBoxEncryptedText.Multiline = true;
            this.textBoxEncryptedText.Name = "textBoxEncryptedText";
            this.textBoxEncryptedText.Size = new System.Drawing.Size(348, 256);
            this.textBoxEncryptedText.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Plain Text";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(409, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Encrypted Text";
            // 
            // buttonProcess
            // 
            this.buttonProcess.Location = new System.Drawing.Point(682, 415);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(75, 23);
            this.buttonProcess.TabIndex = 13;
            this.buttonProcess.Text = "Process";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // checkBoxEncrypt
            // 
            this.checkBoxEncrypt.AutoSize = true;
            this.checkBoxEncrypt.Checked = true;
            this.checkBoxEncrypt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEncrypt.Location = new System.Drawing.Point(311, 134);
            this.checkBoxEncrypt.Name = "checkBoxEncrypt";
            this.checkBoxEncrypt.Size = new System.Drawing.Size(69, 19);
            this.checkBoxEncrypt.TabIndex = 14;
            this.checkBoxEncrypt.Text = "Activate";
            this.checkBoxEncrypt.UseVisualStyleBackColor = true;
            this.checkBoxEncrypt.CheckedChanged += new System.EventHandler(this.checkBoxEncrypt_CheckedChanged);
            // 
            // checkBoxDecrypt
            // 
            this.checkBoxDecrypt.AutoSize = true;
            this.checkBoxDecrypt.Location = new System.Drawing.Point(685, 131);
            this.checkBoxDecrypt.Name = "checkBoxDecrypt";
            this.checkBoxDecrypt.Size = new System.Drawing.Size(69, 19);
            this.checkBoxDecrypt.TabIndex = 15;
            this.checkBoxDecrypt.Text = "Activate";
            this.checkBoxDecrypt.UseVisualStyleBackColor = true;
            this.checkBoxDecrypt.CheckedChanged += new System.EventHandler(this.checkBoxDecrypt_CheckedChanged);
            // 
            // textBoxIV
            // 
            this.textBoxIV.Enabled = false;
            this.textBoxIV.Location = new System.Drawing.Point(93, 69);
            this.textBoxIV.Name = "textBoxIV";
            this.textBoxIV.Size = new System.Drawing.Size(567, 23);
            this.textBoxIV.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "IV";
            // 
            // CryptoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 444);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxIV);
            this.Controls.Add(this.checkBoxDecrypt);
            this.Controls.Add(this.checkBoxEncrypt);
            this.Controls.Add(this.buttonProcess);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEncryptedText);
            this.Controls.Add(this.textBoxPlainText);
            this.Controls.Add(this.radioAESBtn);
            this.Controls.Add(this.radioRSABtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPublicKey);
            this.Controls.Add(this.textBoxPrivateKey);
            this.Controls.Add(this.buttonGenerate);
            this.Name = "CryptoForm";
            this.Text = "CryptoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonGenerate;
        private TextBox textBoxPrivateKey;
        private TextBox textBoxPublicKey;
        private Label label1;
        private Label label2;
        private RadioButton radioRSABtn;
        private RadioButton radioAESBtn;
        private TextBox textBoxPlainText;
        private TextBox textBoxEncryptedText;
        private Label label3;
        private Label label4;
        private Button buttonProcess;
        private CheckBox checkBoxEncrypt;
        private CheckBox checkBoxDecrypt;
        private TextBox textBoxIV;
        private Label label5;
    }
}