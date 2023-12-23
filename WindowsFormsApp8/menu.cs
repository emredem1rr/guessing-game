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
            sesKontrol = false;
        }

        private void PlayGameLabelClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                return;

            Players.Add(new Player() { Name = textBox1.Text });
            Players.Add(new Player() { Name = textBox2.Text });

            Level1Form level1Form = new Level1Form(this.Players,this.sesKontrol);

            // oyun formu gösterme
            level1Form.Show();
            // bu formu gizleme
            this.Hide();
        }

        
    }
}
