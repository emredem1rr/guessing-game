using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp8
{
    public partial class MainMenu : Form
    {
        List<Player> Players = new List<Player>();

        public static string player1Name = "";
        public static string player2Name = "";

        public MainMenu()
        {
            InitializeComponent();
            this.MaximizeBox = false;
        }

        private void PlayGameLabelClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                return;

            Players.Add(new Player() { Name = textBox1.Text });
            Players.Add(new Player() { Name = textBox2.Text });

            Level1Form level1Form = new Level1Form(this.Players);

            // oyun formu gösterme
            level1Form.Show();
            // bu formu gizleme
            this.Hide();
        }
    }
}
