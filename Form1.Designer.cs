namespace CryptoForms
{
    partial class AES256
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AES256));
            this.plain_text = new System.Windows.Forms.TextBox();
            this.CipherText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Encrypt = new System.Windows.Forms.Button();
            this.Decrypt = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.TextHash = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // plain_text
            // 
            this.plain_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plain_text.Location = new System.Drawing.Point(54, 223);
            this.plain_text.Multiline = true;
            this.plain_text.Name = "plain_text";
            this.plain_text.Size = new System.Drawing.Size(289, 63);
            this.plain_text.TabIndex = 0;
            // 
            // CipherText
            // 
            this.CipherText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CipherText.Location = new System.Drawing.Point(464, 223);
            this.CipherText.Multiline = true;
            this.CipherText.Name = "CipherText";
            this.CipherText.ReadOnly = true;
            this.CipherText.Size = new System.Drawing.Size(285, 63);
            this.CipherText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Criptografia Simétrica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.HotPink;
            this.label2.Location = new System.Drawing.Point(109, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto claro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(521, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Texto cifrado";
            // 
            // Encrypt
            // 
            this.Encrypt.BackColor = System.Drawing.Color.Red;
            this.Encrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encrypt.ForeColor = System.Drawing.Color.MediumBlue;
            this.Encrypt.Location = new System.Drawing.Point(88, 301);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(219, 61);
            this.Encrypt.TabIndex = 5;
            this.Encrypt.Text = "Criptografar";
            this.Encrypt.UseVisualStyleBackColor = false;
            this.Encrypt.Click += new System.EventHandler(this.Encrypt_Click);
            // 
            // Decrypt
            // 
            this.Decrypt.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.Decrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt.ForeColor = System.Drawing.Color.MediumBlue;
            this.Decrypt.Location = new System.Drawing.Point(507, 301);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(203, 60);
            this.Decrypt.TabIndex = 6;
            this.Decrypt.Text = "Descriptografar";
            this.Decrypt.UseVisualStyleBackColor = false;
            this.Decrypt.Click += new System.EventHandler(this.Decrypt_Click);
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.PaleTurquoise;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(349, 223);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(109, 63);
            this.Clear.TabIndex = 7;
            this.Clear.Text = "Limpar";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(189, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(387, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Advanced Encrypted Standard  - AES";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.ForeColor = System.Drawing.Color.MediumBlue;
            this.Exit.Location = new System.Drawing.Point(276, 496);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(257, 64);
            this.Exit.TabIndex = 9;
            this.Exit.Text = "Sair";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(377, 408);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "HASH";
            // 
            // TextHash
            // 
            this.TextHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextHash.Location = new System.Drawing.Point(106, 448);
            this.TextHash.Multiline = true;
            this.TextHash.Name = "TextHash";
            this.TextHash.Size = new System.Drawing.Size(653, 25);
            this.TextHash.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(12, 448);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "SHA-256";
            // 
            // AES256
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(800, 572);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextHash);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CipherText);
            this.Controls.Add(this.plain_text);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AES256";
            this.Text = "Cryptograma - AES256";
            this.Load += new System.EventHandler(this.AES256_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox plain_text;
        private System.Windows.Forms.TextBox CipherText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Encrypt;
        private System.Windows.Forms.Button Decrypt;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextHash;
        private System.Windows.Forms.Label label6;
    }
}

