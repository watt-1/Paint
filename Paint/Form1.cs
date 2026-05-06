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
    /// Aktualně vybrané pero pro kreslení popředí
    /// </summary>
    Pen mobjFgPen;

    /// <summary>
    /// Aktualně vybrané pero pro kreslení výplně pozadí
    /// </summary>
    Pen mobjBgPen;

    /// <summary>
    /// Ukládá již nakreslený obraz
    /// </summary>
    Bitmap mobjNakreslenyObraz;

    /// <summary>
    /// Aktuální obraz zobrazovky, který se zobrazuje na PictureBoxu
    /// </summary>
    Bitmap mobjPlatno;

    /// <summary>
    /// Jestli se vybírá barva popředí nebo pozadí
    /// </summary>
    bool mblIsChoosingFgColor = true;


    /// <summary>
    /// Jestli se zobrazuje náhled kreslení (např. při tažení myši), nebo jen již nakreslený obraz
    /// </summary>
    bool mblIsShowingPreview = false;

    /// <summary>
    /// Konstruktor
    /// </summary>
    public FormMain() {
      InitializeComponent();
    }

    private void pbPlatno_Click(object sender, EventArgs e) {

    }

    /// <summary>
    /// Základní nastavení při načtení Formu
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void FormMain_Load(object sender, EventArgs e) {
      mobjFgPen = new Pen(pbBtnSelectFgColor.BackColor);
      mobjBgPen = new Pen(pbBtnSelectBgColor.BackColor);
      NastavTloustku(20);
      VytvorNovouGrafikuAPlatno();
    }

    /// <summary>
    /// Nastaví aktuální barvu, popředí/pozadí dle režimu určeného mblIsChoosingFgColor
    /// </summary>
    /// <param name="vybranaBarva"></param>
    private void NastavBarvu(Color vybranaBarva) {
      if (mblIsChoosingFgColor) {
        mobjFgPen.Color = vybranaBarva;
        pbBtnSelectFgColor.BackColor = vybranaBarva;
      } else {
        mobjBgPen.Color = vybranaBarva;
        pbBtnSelectBgColor.BackColor = vybranaBarva;
      }
      
    }

    /// <summary>
    /// Nastaví aktualní tloušťku pera
    /// </summary>
    /// <param name="tloustka">Nová tloušťka pera</param>
    private void NastavTloustku(int tloustka) {
      trackBarTloustka.Value = tloustka;
      textBoxTloustka.Text = tloustka.ToString();
      mobjFgPen.Width = tloustka;
      mobjBgPen.Width = (tloustka > 2) ? (tloustka - 2) : 0;
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

    private void btnVymazVse_Click(object sender, EventArgs e) {
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
        mobjGrafika.DrawLine(mobjFgPen, mobjMouseDownCoords.X, mobjMouseDownCoords.Y, e.X, e.Y);
        if (mobjBgPen.Width > 0) {
          mobjGrafika.DrawLine(mobjBgPen, mobjMouseDownCoords.X, mobjMouseDownCoords.Y, e.X, e.Y);
        }
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

    /// <summary>
    /// Kliknutí na tlačítko s předdefinovanou barvou
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void pbBtnColor_Click(object sender, EventArgs e) {
      PictureBox pbBtn = (PictureBox)sender;
      NastavBarvu(pbBtn.BackColor);
    }

    /// <summary>
    /// Tlačítko pro výběr vlastní barvy
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void btnCustomColor_Click(object sender, EventArgs e) {

    }

    /// <summary>
    /// Tlačítko pro režim nastavování barvy popředí
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void pbBtnSelectFgColor_Click(object sender, EventArgs e) {
      mblIsChoosingFgColor = true;
    }

    /// <summary>
    /// Tlačítko pro režim nastavování barvy pozadí
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void pbBtnSelectBgColor_Click(object sender, EventArgs e) {
      mblIsChoosingFgColor = false;
    }

    /// <summary>
    /// Změna hodnoty textBoxu pro tloušťku
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void textBoxTloustka_TextChanged(object sender, EventArgs e) {
      int lIntNovaTloustka;
      if (int.TryParse(textBoxTloustka.Text, out lIntNovaTloustka) && lIntNovaTloustka > 0) {
        NastavTloustku(lIntNovaTloustka);
      }
    }

    /// <summary>
    /// Změna posuvníku pro tloušťku
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void trackBarTloustka_Scroll(object sender, EventArgs e) {
      NastavTloustku(trackBarTloustka.Value);
    }
  }
}
