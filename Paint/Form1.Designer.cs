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
      this.button1 = new System.Windows.Forms.Button();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.lblSouradniceMysi = new System.Windows.Forms.ToolStripStatusLabel();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.novýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.otevřítToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.uložitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.konecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.panel1 = new System.Windows.Forms.Panel();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      ((System.ComponentModel.ISupportInitialize)(this.pbPlatno)).BeginInit();
      this.statusStrip1.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // pbPlatno
      // 
      this.pbPlatno.BackColor = System.Drawing.Color.White;
      this.pbPlatno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.pbPlatno.Location = new System.Drawing.Point(3, 3);
      this.pbPlatno.Name = "pbPlatno";
      this.pbPlatno.Size = new System.Drawing.Size(770, 405);
      this.pbPlatno.TabIndex = 0;
      this.pbPlatno.TabStop = false;
      this.pbPlatno.Click += new System.EventHandler(this.pbPlatno_Click);
      this.pbPlatno.Paint += new System.Windows.Forms.PaintEventHandler(this.pbPlatno_Paint);
      this.pbPlatno.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseDown);
      this.pbPlatno.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseMove);
      this.pbPlatno.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbPlatno_MouseUp);
      this.pbPlatno.Resize += new System.EventHandler(this.pbPlatno_Resize);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 27);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Smazat";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.btnClear_Click);
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
      this.novýToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.novýToolStripMenuItem.Text = "Nový";
      this.novýToolStripMenuItem.Click += new System.EventHandler(this.novýToolStripMenuItem_Click);
      // 
      // otevřítToolStripMenuItem
      // 
      this.otevřítToolStripMenuItem.Name = "otevřítToolStripMenuItem";
      this.otevřítToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.otevřítToolStripMenuItem.Text = "Otevřít";
      this.otevřítToolStripMenuItem.Click += new System.EventHandler(this.otevřítToolStripMenuItem_Click);
      // 
      // uložitToolStripMenuItem
      // 
      this.uložitToolStripMenuItem.Name = "uložitToolStripMenuItem";
      this.uložitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.uložitToolStripMenuItem.Text = "Uložit";
      this.uložitToolStripMenuItem.Click += new System.EventHandler(this.uložitToolStripMenuItem_Click);
      // 
      // konecToolStripMenuItem
      // 
      this.konecToolStripMenuItem.Name = "konecToolStripMenuItem";
      this.konecToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.konecToolStripMenuItem.Text = "Konec";
      this.konecToolStripMenuItem.Click += new System.EventHandler(this.konecToolStripMenuItem_Click);
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.pbPlatno);
      this.panel1.Location = new System.Drawing.Point(12, 56);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(776, 411);
      this.panel1.TabIndex = 4;
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.FileName = "openFileDialog1";
      // 
      // FormMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 492);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.button1);
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
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.PictureBox pbPlatno;
    private System.Windows.Forms.Button button1;
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
  }
}

