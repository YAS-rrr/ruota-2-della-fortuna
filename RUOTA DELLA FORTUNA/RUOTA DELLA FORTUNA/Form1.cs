using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace RUOTA_DELLA_FORTUNA
{

    public partial class Form1 : Form
    {

        private readonly string[] premi = {
            "1000€",
            "Affidamento di un bambino orfano!! (a spese tutte tue)",
            "Carcassa di un cervo",
            "Niente"
        };
        private readonly Random random = new Random();
        private float angoloAttuale = 0; // Angolo attuale della ruota
        private Image immagineRuota;

        public Form1()
        {
            InitializeComponent();
            immagineRuota = Properties.Resources.Drawing; // Assicurati che "ruota" esista nelle risorse
            pictureBoxRuota.Image = immagineRuota;
            pictureBoxRuota.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            btnGira.Enabled = false;
            await GiraRuotaAsync();
            btnGira.Enabled = true;
        }

        private async Task GiraRuotaAsync()
        {
            int giri = random.Next(5, 15); // Numero casuale di giri
            int stepPerGiro = 10; // Incremento dell'angolo ad ogni passo
            int totalePassi = giri * (360 / stepPerGiro);

            for (int i = 0; i < totalePassi; i++)
            {
                angoloAttuale = (angoloAttuale + stepPerGiro) % 360;
                RedisegnaRuota(angoloAttuale);
                await Task.Delay(50); // Pausa tra ogni rotazione
            }

            // Una volta finita la rotazione, scegli un premio casuale
            string premio = premi[random.Next(premi.Length)];
            lbl1.Text = $"{premio}";
        }

        private void RedisegnaRuota(float angolo)
        {
            Bitmap bitmapRuotata = new Bitmap(immagineRuota.Width, immagineRuota.Height);
            using (Graphics g = Graphics.FromImage(bitmapRuotata))
            {
                g.TranslateTransform(immagineRuota.Width / 2f, immagineRuota.Height / 2f);
                g.RotateTransform(angolo);
                g.TranslateTransform(-immagineRuota.Width / 2f, -immagineRuota.Height / 2f);
                g.DrawImage(immagineRuota, new Point(0, 0));
            }

            pictureBoxRuota.Image = bitmapRuotata;
        }

        private void lblPremio_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}