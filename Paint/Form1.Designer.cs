namespace Paint {
  partial class FormMain {
    /// <summary>
    /// Vyžaduje se proměnná návrháře.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Uvolněte všechny používané prostředky.
    /// </summary>
    /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Kód generovaný Návrhářem Windows Form

    /// <summary>
    /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
    /// obsah této metody v editoru kódu.
    /// </summary>
    private void InitializeComponent() {
      this.pbPlatno = new System.Windows.Forms.PictureBox();
      this.btnVymazVse = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.lblSouradniceMysi = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.novýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.otevřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.pbBtnSelectFgColor = new System.Windows.Forms.PictureBox();
      this.pbBtnBrownColor = new System.Windows.Forms.PictureBox();
      this.pbBtnBlackColor = new System.Windows.Forms.PictureBox();
      this.pbBtnWhiteColor = new System.Windows.Forms.PictureBox();
      this.pbBtnPurpleColor = new System.Windows.Forms.PictureBox();
      this.pbBtnBlueColor = new System.Windows.Forms.PictureBox();
      this.pbBtnAquaColor = new System.Windows.Forms.PictureBox();
      this.pbBtnGreenColor = new System.Windows.Forms.PictureBox();
      this.pbBtnYellowColor = new System.Windows.Forms.PictureBox();
      this.pbBtnOrangeColor = new System.Windows.Forms.PictureBox();
      this.pbBtnRedColor = new System.Windows.Forms.PictureBox();
      this.pbBtnSelectBgColor = new System.Windows.Forms.PictureBox();
      this.btnCustomColor = new System.Windows.Forms.Button();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.groupBoxNastaveniNastroje = new System.Windows.Forms.GroupBox();
      this.textBoxTloustka = new System.Windows.Forms.TextBox();
      this.trackBarTloustka = new System.Windows.Forms.TrackBar();
      ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).BeginInit();
      this.statusStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnSelectFgColor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnBrownColor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnBlackColor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnWhiteColor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnPurpleColor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnBlueColor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnAquaColor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnGreenColor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnYellowColor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnOrangeColor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnRedColor)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnSelectBgColor)).BeginInit();
      this.groupBoxNastaveniNastroje.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarTloustka)).BeginInit();
      this.SuspendLayout();
      // 
      // pbPlatno
      // 
      this.pbPlatno.BackColor = System.Drawing.Color.White;
      this.pbPlatno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pbPlatno.Location = new System.Drawing.Point(134, 119);
      this.pbPlatno.Name = "pbPlatno";
      this.pbPlatno.Size = new System.Drawing.Size(654, 348);
      this.pbPlatno.TabIndex = 0;
      this.pbPlatno.TabStop = false;
      this.pbPlatno.Click += new System.EventHandler(this.pbPlatno_Click);
      this.pbPlatno.Paint += new System.Windows.Forms.PaintEventHandler(this.pbPlatno_Paint);
      this.pbPlatno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseDown);
      this.pbPlatno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseMove);
      this.pbPlatno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseUp);
      this.pbPlatno.Resize += new System.EventHandler(this.pbPlatno_Resize);
      // 
      // btnVymazVse
      // 
      this.btnVymazVse.Location = new System.Drawing.Point(12, 27);
      this.btnVymazVse.Name = "btnVymazVse";
      this.btnVymazVse.Size = new System.Drawing.Size(75, 23);
      this.btnVymazVse.TabIndex = 1;
      this.btnVymazVse.Text = "Smazat";
      this.btnVymazVse.UseVisualStyleBackColor = true;
      this.btnVymazVse.Click += new System.EventHandler(this.btnVymazVse_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSouradniceMysi});
      this.statusStrip1.Location = new System.Drawing.Point(0, 470);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(800, 22);
      this.statusStrip1.TabIndex = 2;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // lblSouradniceMysi
      // 
      this.lblSouradniceMysi.Name = "lblSouradniceMysi";
      this.lblSouradniceMysi.Size = new System.Drawing.Size(118, 17);
      this.lblSouradniceMysi.Text = "toolStripStatusLabel1";
      this.lblSouradniceMysi.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(800, 24);
      this.menuStrip1.TabIndex = 3;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // souborToolStripMenuItem
      // 
      this.souborToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novýToolStripMenuItem,
            this.otevřítToolStripMenuItem,
            this.uložitToolStripMenuItem,
            this.konecToolStripMenuItem});
      this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
      this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
      this.souborToolStripMenuItem.Text = "Soubor";
      // 
      // novýToolStripMenuItem
      // 
      this.novýToolStripMenuItem.Name = "novýToolStripMenuItem";
      this.novýToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
      this.novýToolStripMenuItem.Text = "Nový";
      this.novýToolStripMenuItem.Click += new System.EventHandler(this.novýToolStripMenuItem_Click);
      // 
      // otevřítToolStripMenuItem
      // 
      this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
      this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
      this.otevřítToolStripMenuItem.Text = "Otevřít";
      this.otevřítToolStripMenuItem.Click += new System.EventHandler(this.otevřítToolStripMenuItem_Click);
      // 
      // uložitToolStripMenuItem
      // 
      this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
      this.uložitToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
      this.uložitToolStripMenuItem.Text = "Uložit";
      this.uložitToolStripMenuItem.Click += new System.EventHandler(this.uložitToolStripMenuItem_Click);
      // 
      // konecToolStripMenuItem
      // 
      this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
      this.konecToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
      this.konecToolStripMenuItem.Text = "Konec";
      this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.pbBtnSelectFgColor);
      this.panel1.Controls.Add(this.pbBtnBrownColor);
      this.panel1.Controls.Add(this.pbBtnBlackColor);
      this.panel1.Controls.Add(this.pbBtnWhiteColor);
      this.panel1.Controls.Add(this.pbBtnPurpleColor);
      this.panel1.Controls.Add(this.pbBtnBlueColor);
      this.panel1.Controls.Add(this.pbBtnAquaColor);
      this.panel1.Controls.Add(this.pbBtnGreenColor);
      this.panel1.Controls.Add(this.pbBtnYellowColor);
      this.panel1.Controls.Add(this.pbBtnOrangeColor);
      this.panel1.Controls.Add(this.pbBtnRedColor);
      this.panel1.Controls.Add(this.pbBtnSelectBgColor);
      this.panel1.Controls.Add(this.btnCustomColor);
      this.panel1.Location = new System.Drawing.Point(12, 56);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(116, 411);
      this.panel1.TabIndex = 4;
      // 
      // pbBtnSelectFgColor
      // 
      this.pbBtnSelectFgColor.BackColor = System.Drawing.Color.Black;
      this.pbBtnSelectFgColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBtnSelectFgColor.Location = new System.Drawing.Point(17, 14);
      this.pbBtnSelectFgColor.Name = "pbBtnSelectFgColor";
      this.pbBtnSelectFgColor.Size = new System.Drawing.Size(58, 42);
      this.pbBtnSelectFgColor.TabIndex = 1;
      this.pbBtnSelectFgColor.TabStop = false;
      this.pbBtnSelectFgColor.Click += new System.EventHandler(this.pbBtnSelectFgColor_Click);
      // 
      // pbBtnBrownColor
      // 
      this.pbBtnBrownColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.pbBtnBrownColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBtnBrownColor.Location = new System.Drawing.Point(62, 205);
      this.pbBtnBrownColor.Name = "pbBtnBrownColor";
      this.pbBtnBrownColor.Size = new System.Drawing.Size(36, 33);
      this.pbBtnBrownColor.TabIndex = 12;
      this.pbBtnBrownColor.TabStop = false;
      this.pbBtnBrownColor.Click += new System.EventHandler(this.pbBtnColor_Click);
      // 
      // pbBtnBlackColor
      // 
      this.pbBtnBlackColor.BackColor = System.Drawing.Color.Black;
      this.pbBtnBlackColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBtnBlackColor.Location = new System.Drawing.Point(62, 244);
      this.pbBtnBlackColor.Name = "pbBtnBlackColor";
      this.pbBtnBlackColor.Size = new System.Drawing.Size(36, 33);
      this.pbBtnBlackColor.TabIndex = 11;
      this.pbBtnBlackColor.TabStop = false;
      this.pbBtnBlackColor.Click += new System.EventHandler(this.pbBtnColor_Click);
      // 
      // pbBtnWhiteColor
      // 
      this.pbBtnWhiteColor.BackColor = System.Drawing.Color.White;
      this.pbBtnWhiteColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBtnWhiteColor.Location = new System.Drawing.Point(17, 244);
      this.pbBtnWhiteColor.Name = "pbBtnWhiteColor";
      this.pbBtnWhiteColor.Size = new System.Drawing.Size(36, 33);
      this.pbBtnWhiteColor.TabIndex = 10;
      this.pbBtnWhiteColor.TabStop = false;
      this.pbBtnWhiteColor.Click += new System.EventHandler(this.pbBtnColor_Click);
      // 
      // pbBtnPurpleColor
      // 
      this.pbBtnPurpleColor.BackColor = System.Drawing.Color.Fuchsia;
      this.pbBtnPurpleColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBtnPurpleColor.Location = new System.Drawing.Point(62, 170);
      this.pbBtnPurpleColor.Name = "pbBtnPurpleColor";
      this.pbBtnPurpleColor.Size = new System.Drawing.Size(36, 29);
      this.pbBtnPurpleColor.TabIndex = 9;
      this.pbBtnPurpleColor.TabStop = false;
      this.pbBtnPurpleColor.Click += new System.EventHandler(this.pbBtnColor_Click);
      // 
      // pbBtnBlueColor
      // 
      this.pbBtnBlueColor.BackColor = System.Drawing.Color.Blue;
      this.pbBtnBlueColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBtnBlueColor.Location = new System.Drawing.Point(62, 133);
      this.pbBtnBlueColor.Name = "pbBtnBlueColor";
      this.pbBtnBlueColor.Size = new System.Drawing.Size(36, 31);
      this.pbBtnBlueColor.TabIndex = 8;
      this.pbBtnBlueColor.TabStop = false;
      this.pbBtnBlueColor.Click += new System.EventHandler(this.pbBtnColor_Click);
      // 
      // pbBtnAquaColor
      // 
      this.pbBtnAquaColor.BackColor = System.Drawing.Color.Aqua;
      this.pbBtnAquaColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBtnAquaColor.Location = new System.Drawing.Point(62, 96);
      this.pbBtnAquaColor.Name = "pbBtnAquaColor";
      this.pbBtnAquaColor.Size = new System.Drawing.Size(36, 31);
      this.pbBtnAquaColor.TabIndex = 7;
      this.pbBtnAquaColor.TabStop = false;
      this.pbBtnAquaColor.Click += new System.EventHandler(this.pbBtnColor_Click);
      // 
      // pbBtnGreenColor
      // 
      this.pbBtnGreenColor.BackColor = System.Drawing.Color.Lime;
      this.pbBtnGreenColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBtnGreenColor.Location = new System.Drawing.Point(17, 205);
      this.pbBtnGreenColor.Name = "pbBtnGreenColor";
      this.pbBtnGreenColor.Size = new System.Drawing.Size(36, 33);
      this.pbBtnGreenColor.TabIndex = 6;
      this.pbBtnGreenColor.TabStop = false;
      this.pbBtnGreenColor.Click += new System.EventHandler(this.pbBtnColor_Click);
      // 
      // pbBtnYellowColor
      // 
      this.pbBtnYellowColor.BackColor = System.Drawing.Color.Yellow;
      this.pbBtnYellowColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBtnYellowColor.Location = new System.Drawing.Point(17, 170);
      this.pbBtnYellowColor.Name = "pbBtnYellowColor";
      this.pbBtnYellowColor.Size = new System.Drawing.Size(36, 29);
      this.pbBtnYellowColor.TabIndex = 5;
      this.pbBtnYellowColor.TabStop = false;
      this.pbBtnYellowColor.Click += new System.EventHandler(this.pbBtnColor_Click);
      // 
      // pbBtnOrangeColor
      // 
      this.pbBtnOrangeColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
      this.pbBtnOrangeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBtnOrangeColor.Location = new System.Drawing.Point(17, 133);
      this.pbBtnOrangeColor.Name = "pbBtnOrangeColor";
      this.pbBtnOrangeColor.Size = new System.Drawing.Size(36, 31);
      this.pbBtnOrangeColor.TabIndex = 4;
      this.pbBtnOrangeColor.TabStop = false;
      this.pbBtnOrangeColor.Click += new System.EventHandler(this.pbBtnColor_Click);
      // 
      // pbBtnRedColor
      // 
      this.pbBtnRedColor.BackColor = System.Drawing.Color.Red;
      this.pbBtnRedColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBtnRedColor.Location = new System.Drawing.Point(17, 96);
      this.pbBtnRedColor.Name = "pbBtnRedColor";
      this.pbBtnRedColor.Size = new System.Drawing.Size(36, 31);
      this.pbBtnRedColor.TabIndex = 3;
      this.pbBtnRedColor.TabStop = false;
      this.pbBtnRedColor.Click += new System.EventHandler(this.pbBtnColor_Click);
      // 
      // pbBtnSelectBgColor
      // 
      this.pbBtnSelectBgColor.BackColor = System.Drawing.Color.White;
      this.pbBtnSelectBgColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pbBtnSelectBgColor.Location = new System.Drawing.Point(40, 31);
      this.pbBtnSelectBgColor.Name = "pbBtnSelectBgColor";
      this.pbBtnSelectBgColor.Size = new System.Drawing.Size(58, 42);
      this.pbBtnSelectBgColor.TabIndex = 2;
      this.pbBtnSelectBgColor.TabStop = false;
      this.pbBtnSelectBgColor.Click += new System.EventHandler(this.pbBtnSelectBgColor_Click);
      // 
      // btnCustomColor
      // 
      this.btnCustomColor.Location = new System.Drawing.Point(17, 339);
      this.btnCustomColor.Name = "btnCustomColor";
      this.btnCustomColor.Size = new System.Drawing.Size(58, 22);
      this.btnCustomColor.TabIndex = 0;
      this.btnCustomColor.Text = "...";
      this.btnCustomColor.UseVisualStyleBackColor = true;
      this.btnCustomColor.Click += new System.EventHandler(this.btnCustomColor_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // groupBoxNastaveniNastroje
      // 
      this.groupBoxNastaveniNastroje.Controls.Add(this.textBoxTloustka);
      this.groupBoxNastaveniNastroje.Controls.Add(this.trackBarTloustka);
      this.groupBoxNastaveniNastroje.Location = new System.Drawing.Point(134, 12);
      this.groupBoxNastaveniNastroje.Name = "groupBoxNastaveniNastroje";
      this.groupBoxNastaveniNastroje.Size = new System.Drawing.Size(654, 100);
      this.groupBoxNastaveniNastroje.TabIndex = 5;
      this.groupBoxNastaveniNastroje.TabStop = false;
      this.groupBoxNastaveniNastroje.Text = "Nástroj";
      // 
      // textBoxTloustka
      // 
      this.textBoxTloustka.Location = new System.Drawing.Point(116, 44);
      this.textBoxTloustka.Name = "textBoxTloustka";
      this.textBoxTloustka.Size = new System.Drawing.Size(43, 20);
      this.textBoxTloustka.TabIndex = 1;
      this.textBoxTloustka.TextChanged += new System.EventHandler(this.textBoxTloustka_TextChanged);
      // 
      // trackBarTloustka
      // 
      this.trackBarTloustka.Location = new System.Drawing.Point(6, 44);
      this.trackBarTloustka.Maximum = 50;
      this.trackBarTloustka.Minimum = 1;
      this.trackBarTloustka.Name = "trackBarTloustka";
      this.trackBarTloustka.Size = new System.Drawing.Size(104, 45);
      this.trackBarTloustka.TabIndex = 0;
      this.trackBarTloustka.Value = 10;
      this.trackBarTloustka.Scroll += new System.EventHandler(this.trackBarTloustka_Scroll);
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 492);
      this.Controls.Add(this.groupBoxNastaveniNastroje);
      this.Controls.Add(this.pbPlatno);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.btnVymazVse);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "FormMain";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.FormMain_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).EndInit();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.panel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnSelectFgColor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnBrownColor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnBlackColor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnWhiteColor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnPurpleColor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnBlueColor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnAquaColor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnGreenColor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnYellowColor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnOrangeColor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnRedColor)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pbBtnSelectBgColor)).EndInit();
      this.groupBoxNastaveniNastroje.ResumeLayout(false);
      this.groupBoxNastaveniNastroje.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.trackBarTloustka)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pbPlatno;
    private System.Windows.Forms.Button btnVymazVse;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel lblSouradniceMysi;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem novýToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem otevřítToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem uložitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem konecToolStripMenuItem;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.Button btnCustomColor;
    private System.Windows.Forms.GroupBox groupBoxNastaveniNastroje;
    private System.Windows.Forms.TrackBar trackBarTloustka;
    private System.Windows.Forms.PictureBox pbBtnGreenColor;
    private System.Windows.Forms.PictureBox pbBtnYellowColor;
    private System.Windows.Forms.PictureBox pbBtnOrangeColor;
    private System.Windows.Forms.PictureBox pbBtnRedColor;
    private System.Windows.Forms.PictureBox pbBtnSelectBgColor;
    private System.Windows.Forms.PictureBox pbBtnSelectFgColor;
    private System.Windows.Forms.PictureBox pbBtnBrownColor;
    private System.Windows.Forms.PictureBox pbBtnBlackColor;
    private System.Windows.Forms.PictureBox pbBtnWhiteColor;
    private System.Windows.Forms.PictureBox pbBtnPurpleColor;
    private System.Windows.Forms.PictureBox pbBtnBlueColor;
    private System.Windows.Forms.PictureBox pbBtnAquaColor;
    private System.Windows.Forms.TextBox textBoxTloustka;
  }
}

