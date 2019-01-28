namespace MijajlovicMarkoDateTimePicker
{
    partial class formRezervacijaLeta
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
            this.dateDatumLeta = new System.Windows.Forms.DateTimePicker();
            this.dateVrijemeLeta = new System.Windows.Forms.DateTimePicker();
            this.btnRezervacija = new System.Windows.Forms.Button();
            this.rtxtLet = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dateDatumLeta
            // 
            this.dateDatumLeta.Location = new System.Drawing.Point(169, 37);
            this.dateDatumLeta.Name = "dateDatumLeta";
            this.dateDatumLeta.Size = new System.Drawing.Size(200, 20);
            this.dateDatumLeta.TabIndex = 0;
            // 
            // dateVrijemeLeta
            // 
            this.dateVrijemeLeta.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateVrijemeLeta.Location = new System.Drawing.Point(169, 67);
            this.dateVrijemeLeta.Name = "dateVrijemeLeta";
            this.dateVrijemeLeta.ShowUpDown = true;
            this.dateVrijemeLeta.Size = new System.Drawing.Size(200, 20);
            this.dateVrijemeLeta.TabIndex = 1;
            // 
            // btnRezervacija
            // 
            this.btnRezervacija.Location = new System.Drawing.Point(160, 246);
            this.btnRezervacija.Name = "btnRezervacija";
            this.btnRezervacija.Size = new System.Drawing.Size(75, 23);
            this.btnRezervacija.TabIndex = 2;
            this.btnRezervacija.Text = "Rezerviraj";
            this.btnRezervacija.UseVisualStyleBackColor = true;
            this.btnRezervacija.Click += new System.EventHandler(this.btnRezervacija_Click);
            // 
            // rtxtLet
            // 
            this.rtxtLet.Location = new System.Drawing.Point(32, 107);
            this.rtxtLet.Name = "rtxtLet";
            this.rtxtLet.Size = new System.Drawing.Size(337, 124);
            this.rtxtLet.TabIndex = 3;
            this.rtxtLet.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Izaberite datum leta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Izaberite vrijeme leta:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // formRezervacijaLeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 281);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtxtLet);
            this.Controls.Add(this.btnRezervacija);
            this.Controls.Add(this.dateVrijemeLeta);
            this.Controls.Add(this.dateDatumLeta);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "formRezervacijaLeta";
            this.Text = "DateTimePicker kontrola";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateDatumLeta;
        private System.Windows.Forms.DateTimePicker dateVrijemeLeta;
        private System.Windows.Forms.Button btnRezervacija;
        private System.Windows.Forms.RichTextBox rtxtLet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
    }
}

