namespace MijajlovicMarkoTrackBarKontrola
{
    partial class CreativeCommonsLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreativeCommonsLicense));
            this.lblSeperatorLine = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOpisPrograma = new System.Windows.Forms.Label();
            this.linkLabelCreativeCommons = new System.Windows.Forms.LinkLabel();
            this.lblCreative = new System.Windows.Forms.Label();
            this.btnZatvori = new System.Windows.Forms.Button();
            this.pboxCreativeCommonsSlika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxCreativeCommonsSlika)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeperatorLine
            // 
            this.lblSeperatorLine.AutoSize = true;
            this.lblSeperatorLine.Location = new System.Drawing.Point(106, 130);
            this.lblSeperatorLine.Name = "lblSeperatorLine";
            this.lblSeperatorLine.Size = new System.Drawing.Size(0, 13);
            this.lblSeperatorLine.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(119, 128);
            this.label1.MaximumSize = new System.Drawing.Size(0, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 2);
            this.label1.TabIndex = 14;
            this.label1.Text = "label1";
            // 
            // lblOpisPrograma
            // 
            this.lblOpisPrograma.AutoSize = true;
            this.lblOpisPrograma.Location = new System.Drawing.Point(22, 20);
            this.lblOpisPrograma.Name = "lblOpisPrograma";
            this.lblOpisPrograma.Size = new System.Drawing.Size(240, 104);
            this.lblOpisPrograma.TabIndex = 13;
            this.lblOpisPrograma.Text = "O programu:\r\n\r\nProgram upisuje odgovarajući odgovor u text box \r\novisno o odabran" +
    "om radio buttonu.\r\n\r\nIzradio: Marko Mijajlović\r\nRazred: 3.d\r\nDatum: 22. siječnja" +
    " 2019.\r\n";
            // 
            // linkLabelCreativeCommons
            // 
            this.linkLabelCreativeCommons.AutoSize = true;
            this.linkLabelCreativeCommons.Location = new System.Drawing.Point(92, 211);
            this.linkLabelCreativeCommons.Name = "linkLabelCreativeCommons";
            this.linkLabelCreativeCommons.Size = new System.Drawing.Size(95, 13);
            this.linkLabelCreativeCommons.TabIndex = 12;
            this.linkLabelCreativeCommons.TabStop = true;
            this.linkLabelCreativeCommons.Text = "Creative Commons";
            this.linkLabelCreativeCommons.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCreativeCommons_LinkClicked);
            // 
            // lblCreative
            // 
            this.lblCreative.AutoSize = true;
            this.lblCreative.Location = new System.Drawing.Point(15, 155);
            this.lblCreative.Name = "lblCreative";
            this.lblCreative.Size = new System.Drawing.Size(265, 39);
            this.lblCreative.TabIndex = 11;
            this.lblCreative.Text = "Davatelj licence dopušta umnožavanje, distribuiranje i \r\npriopćavanje djela javno" +
    "sti. Zauzvrat primatelji licence\r\n moraju imenovanjem priznati i označiti izvorn" +
    "og autora.";
            // 
            // btnZatvori
            // 
            this.btnZatvori.Location = new System.Drawing.Point(107, 293);
            this.btnZatvori.Name = "btnZatvori";
            this.btnZatvori.Size = new System.Drawing.Size(64, 23);
            this.btnZatvori.TabIndex = 10;
            this.btnZatvori.Text = "Zatvori";
            this.btnZatvori.UseVisualStyleBackColor = true;
            // 
            // pboxCreativeCommonsSlika
            // 
            this.pboxCreativeCommonsSlika.Image = ((System.Drawing.Image)(resources.GetObject("pboxCreativeCommonsSlika.Image")));
            this.pboxCreativeCommonsSlika.Location = new System.Drawing.Point(95, 244);
            this.pboxCreativeCommonsSlika.Name = "pboxCreativeCommonsSlika";
            this.pboxCreativeCommonsSlika.Size = new System.Drawing.Size(87, 31);
            this.pboxCreativeCommonsSlika.TabIndex = 9;
            this.pboxCreativeCommonsSlika.TabStop = false;
            // 
            // CreativeCommonsLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 331);
            this.Controls.Add(this.lblSeperatorLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblOpisPrograma);
            this.Controls.Add(this.linkLabelCreativeCommons);
            this.Controls.Add(this.lblCreative);
            this.Controls.Add(this.btnZatvori);
            this.Controls.Add(this.pboxCreativeCommonsSlika);
            this.Name = "CreativeCommonsLicense";
            this.Text = "CreativeCommonsLicense";
            ((System.ComponentModel.ISupportInitialize)(this.pboxCreativeCommonsSlika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSeperatorLine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOpisPrograma;
        private System.Windows.Forms.LinkLabel linkLabelCreativeCommons;
        private System.Windows.Forms.Label lblCreative;
        private System.Windows.Forms.Button btnZatvori;
        private System.Windows.Forms.PictureBox pboxCreativeCommonsSlika;
    }
}