using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp8
{
    public partial class MainMenu : Form
    {
        
        List<Player> Players = new List<Player>();


        private SoundPlayer dogruSesi = new SoundPlayer(Resource1.dogruSesi);
        private SoundPlayer yanlisSesi = new SoundPlayer(Resource1.yanlisSesi);

        public static string player1Name = "";
        public static string player2Name = "";
        private static bool sesKontrol = true;
        
        public MainMenu()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }
        private void pictureBox1_Click(object sender, EventArgs e) //ses kapatma
        {
            sesKontrol = !sesKontrol;
            if(!sesKontrol)
            pictureBox1.Image = Resource1.mute;
            if(sesKontrol ) pictureBox1.Image = Resource1.volume_up;
        }

        private void PlayGameLabelClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                return;

            Players.Add(new Player() { Name = textBox1.Text });
            Players.Add(new Player() { Name = textBox2.Text });

            Level1Form level1Form = new Level1Form(this.Players,sesKontrol);

            // oyun formu gösterme
            level1Form.Show();
            // bu formu gizleme
            this.Hide();
        }

        private void instaBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/emre.dem1r/");
        }

        private void pictureBox2_Click(object sender, EventArgs e) //Twitter
        {
            System.Diagnostics.Process.Start("https://twitter.com/emredem1r_");
        }

        private void linkedinBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.linkedin.com/in/emre-demir-7a1757257/");
        }

        private void githubBox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/emredem1rr");
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba, oyunuma HOŞ GELDİNİZ.\n" +
                            "Oyuna başlamak için oyuncu isimlerini girip 'OYNA' butonuna basmanız yeterlidir.\n" +
                            "Oyun başladıktan sonra 'GÖSTER' butonuna basıp oluşan şeklin bitmesini bekleyiniz.\n" +
                            "Şekil oluştuktan sonra 'BAŞLA' butonuna basarak sürenizi başlatıp tahmin etmeye başlayabilirsiniz.\n" +
                            "Eğer tahmininizde emin olamayıp 'TESLİM OL' butonuna basmak isterseniz 15 puan kaybedeceksiniz.\n" +
                            "Yanlış bildiğiniz her kutuda 10 puan kaybedeceksiniz.\n" +
                            "Rakibinizden kısa sürede bitirdiğiniz taktirde ek 10 puan alacaksınız.\n\n" +
                            "Doğru bildiğiniz her bir kutu için puan sistemi şu şekildedir: \n" +
                            "1.level : 5  puan\n" +
                            "2.level : 7  puan\n" +
                            "3.level : 10 puan\n");
            
        }
    }
}
