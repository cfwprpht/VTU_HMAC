namespace VTU_HMAC
{
    partial class VTU_HMAC
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VTU_HMAC));
            this.textLink = new System.Windows.Forms.TextBox();
            this.buttonHash = new System.Windows.Forms.Button();
            this.textHash = new System.Windows.Forms.TextBox();
            this.buttonClearText = new System.Windows.Forms.Button();
            this.buttonClearHash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkConfig = new System.Windows.Forms.CheckBox();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.labelKey = new System.Windows.Forms.Label();
            this.textTitleID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLink
            // 
            this.textLink.Location = new System.Drawing.Point(112, 12);
            this.textLink.Name = "textLink";
            this.textLink.Size = new System.Drawing.Size(1140, 20);
            this.textLink.TabIndex = 0;
            this.textLink.Text = "https://gs-sec.ww.np.dl.playstation.net/pl/np/";
            // 
            // buttonHash
            // 
            this.buttonHash.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHash.ForeColor = System.Drawing.Color.Blue;
            this.buttonHash.Location = new System.Drawing.Point(328, 80);
            this.buttonHash.Name = "buttonHash";
            this.buttonHash.Size = new System.Drawing.Size(781, 35);
            this.buttonHash.TabIndex = 1;
            this.buttonHash.Text = "Generate Hashed Link";
            this.buttonHash.UseVisualStyleBackColor = true;
            this.buttonHash.Click += new System.EventHandler(this.buttonHash_Click);
            // 
            // textHash
            // 
            this.textHash.Location = new System.Drawing.Point(112, 54);
            this.textHash.Name = "textHash";
            this.textHash.Size = new System.Drawing.Size(1140, 20);
            this.textHash.TabIndex = 2;
            // 
            // buttonClearText
            // 
            this.buttonClearText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClearText.BackgroundImage")));
            this.buttonClearText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClearText.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonClearText.Location = new System.Drawing.Point(1258, 6);
            this.buttonClearText.Name = "buttonClearText";
            this.buttonClearText.Size = new System.Drawing.Size(30, 30);
            this.buttonClearText.TabIndex = 4;
            this.buttonClearText.UseVisualStyleBackColor = true;
            this.buttonClearText.Click += new System.EventHandler(this.buttonClearText_Click);
            // 
            // buttonClearHash
            // 
            this.buttonClearHash.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonClearHash.BackgroundImage")));
            this.buttonClearHash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonClearHash.Location = new System.Drawing.Point(1258, 48);
            this.buttonClearHash.Name = "buttonClearHash";
            this.buttonClearHash.Size = new System.Drawing.Size(30, 30);
            this.buttonClearHash.TabIndex = 5;
            this.buttonClearHash.UseVisualStyleBackColor = true;
            this.buttonClearHash.Click += new System.EventHandler(this.buttonClearHash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Link is:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hashed Link is:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1260, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "v0.1";
            // 
            // checkConfig
            // 
            this.checkConfig.AutoSize = true;
            this.checkConfig.Location = new System.Drawing.Point(114, 97);
            this.checkConfig.Name = "checkConfig";
            this.checkConfig.Size = new System.Drawing.Size(85, 17);
            this.checkConfig.TabIndex = 9;
            this.checkConfig.Text = "custom Path";
            this.checkConfig.UseVisualStyleBackColor = true;
            this.checkConfig.CheckedChanged += new System.EventHandler(this.checkConfig_CheckedChanged);
            // 
            // buttonConfig
            // 
            this.buttonConfig.Location = new System.Drawing.Point(200, 94);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(75, 23);
            this.buttonConfig.TabIndex = 10;
            this.buttonConfig.Text = "config";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Location = new System.Drawing.Point(112, 79);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(74, 13);
            this.labelKey.TabIndex = 11;
            this.labelKey.Text = "Key: Not Valid";
            // 
            // textTitleID
            // 
            this.textTitleID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.textTitleID.Location = new System.Drawing.Point(112, 33);
            this.textTitleID.Name = "textTitleID";
            this.textTitleID.Size = new System.Drawing.Size(150, 20);
            this.textTitleID.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "TitleID:";
            // 
            // VTU_HMAC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 122);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textTitleID);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.buttonConfig);
            this.Controls.Add(this.checkConfig);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClearHash);
            this.Controls.Add(this.buttonClearText);
            this.Controls.Add(this.textHash);
            this.Controls.Add(this.buttonHash);
            this.Controls.Add(this.textLink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "VTU_HMAC";
            this.Text = "Vita Title Update HMAC-256 Tool";
            this.Load += new System.EventHandler(this.VTU_HMAC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textLink;
        private System.Windows.Forms.Button buttonHash;
        private System.Windows.Forms.TextBox textHash;
        private System.Windows.Forms.Button buttonClearText;
        private System.Windows.Forms.Button buttonClearHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkConfig;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.TextBox textTitleID;
        private System.Windows.Forms.Label label4;
    }
}

