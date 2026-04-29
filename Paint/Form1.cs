using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint {
  public partial class FormMain : Form {
    
    /// <summary>
    /// třída pro kreslení
    /// </summary>
    Graphics mobjGrafika;

    /// <summary>
    /// Souřadnice myši při posledním MouseDown
    /// </summary>
    Point mobjMouseDownCoords;

    /// <summary>
    /// Aktualně vybrané pero
    /// </summary>
    Pen mobjPen;
    
    /// <summary>
    /// Aktuálně vybraný brush
    /// </summary>
    Brush mobjBrush;

    /// <summary>
    /// Ukládá již nakreslený obraz
    /// </summary>
    Bitmap mobjNakreslenyObraz;

    /// <summary>
    /// Aktuální obraz zobrazovky, který se zobrazuje na PictureBoxu
    /// </summary>
    Bitmap mobjPlatno;


    /// <summary>
    /// Jestli se zobrazuje náhled kreslení (např. při tažení myši), nebo jen již nakreslený obraz
    /// </summary>
    bool mblIsShowingPreview = false;

    /// <summary>
    /// Konstruktor
    /// </summary>
    public FormMain() {
      InitializeComponent();

      mobjPen = new Pen(Color.FromArgb(255, 0, 0), 5);
    }

    private void pbPlatno_Click(object sender, EventArgs e) {

    }

    /// <summary>
    /// Základní nastavení při načtení Formu
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FormMain_Load(object sender, EventArgs e) {
      VytvorNovouGrafikuAPlatno();
    }


    /// <summary>
    /// Uloží aktuální obraz na plátně pro účely vykreslování náhledu změn nad něj
    /// </summary>
    private void UlozPlatnoNakreslenyObraz() {
      if (mobjNakreslenyObraz != null) {
        mobjNakreslenyObraz.Dispose();
      }
      mobjNakreslenyObraz = new Bitmap(mobjPlatno);
    } 

    /// <summary>
    /// Vytvoří novou grafiku a plátno a překreslí obsah starého plátna na nové
    /// </summary>
    private void VytvorNovouGrafikuAPlatno() {
      Bitmap lobjNovePlatno = new Bitmap(pbPlatno.Width, pbPlatno.Height);
      if (mobjGrafika != null) {
        mobjGrafika.Dispose();
      }
      mobjGrafika = Graphics.FromImage(lobjNovePlatno);
      mobjGrafika.Clear(Color.White);
      if (mobjPlatno != null) {
        mobjGrafika.DrawImageUnscaled(mobjPlatno, 0, 0);
      }
      mobjPlatno = lobjNovePlatno;
    }

    private void btnClear_Click(object sender, EventArgs e) {
      mobjGrafika.Clear(Color.White);
      pbPlatno.Invalidate();
    }

    private void toolStripStatusLabel1_Click(object sender, EventArgs e) {

    }

    /// <summary>
    /// Stisk tlačítka myši na plátnu
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void pbPlatno_MouseDown(object sender, MouseEventArgs e) {
      if (e.Button == MouseButtons.Left) {
        mobjMouseDownCoords.X = e.X;
        mobjMouseDownCoords.Y = e.Y;
        UlozPlatnoNakreslenyObraz();
        mblIsShowingPreview = true;
      }
    }

    /// <summary>
    /// Obsluha pohybu myši nad plátnem
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void pbPlatno_MouseMove(object sender, MouseEventArgs e) {
      lblSouradniceMysi.Text = "x: " + e.X + ", y: " + e.Y;

      if (mblIsShowingPreview) {
        mobjGrafika.DrawImageUnscaled(mobjNakreslenyObraz, 0, 0);
        mobjGrafika.DrawLine(mobjPen, mobjMouseDownCoords.X, mobjMouseDownCoords.Y, e.X, e.Y);
        pbPlatno.Invalidate();
      }
    }

    /// <summary>
    /// Pouštění tlačítka myši na plátnu
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void pbPlatno_MouseUp(object sender, MouseEventArgs e) {
      mblIsShowingPreview = false;
      pbPlatno.Invalidate();
    }

    /// <summary>
    /// Při změně velikosti plátna vytvoří nové plátno a překreslí obsah starého na nové
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void pbPlatno_Resize(object sender, EventArgs e) {
      VytvorNovouGrafikuAPlatno();
    }

    /// <summary>
    /// Vykreslení bitmapy plátna v paměti na PictureBox
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void pbPlatno_Paint(object sender, PaintEventArgs e) {
      if (mobjPlatno != null) {
        e.Graphics.DrawImageUnscaled(mobjPlatno, 0, 0);
      }
    }

    /// <summary>
    /// Menu -> Nový
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void novýToolStripMenuItem_Click(object sender, EventArgs e) {
      // vyčistit grafiku
      mobjGrafika.Clear(Color.White);
      // vykreslení
      pbPlatno.Invalidate();
    }

    /// <summary>
    /// Menu -> Konec
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void konecToolStripMenuItem_Click(object sender, EventArgs e) {
      Application.Exit();
    }

    /// <summary>
    /// Menu -> Uložit
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void uložitToolStripMenuItem_Click(object sender, EventArgs e) {
      string lStrFilePath;
      // zobrazení dialogu
      DialogResult result = saveFileDialog1.ShowDialog();

      if (result == DialogResult.OK) {
        lStrFilePath = saveFileDialog1.FileName + ".png";

        // uložit
        mobjPlatno.Save(lStrFilePath, ImageFormat.Png);
      }
    }

    /// <summary>
    /// Menu -> Otevřít
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void otevřítToolStripMenuItem_Click(object sender, EventArgs e) {
      string lStrFilePath;
      // zobrazení dialogu
      DialogResult result = openFileDialog1.ShowDialog();
      if (result == DialogResult.OK) {
        lStrFilePath = openFileDialog1.FileName;
        Bitmap bitmap = new Bitmap(lStrFilePath);
        // vyčistit a načíst obrázek
        mobjGrafika.Clear(Color.White);
        mobjGrafika.DrawImageUnscaled(bitmap, 0, 0);
      }
    }
  }
}
