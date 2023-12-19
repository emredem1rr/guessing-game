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
    public partial class Form1 : Form
    {
        int dak = 0;
        int saniye = 0;
        bool gameStart = false;
        bool selectedTeam = false;

        List<Button> map = new List<Button>();
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) //süre sayac yeri
        {
            timer1.Interval = 1000;
            saniye = saniye + 1;
            saniyeLbl.Text = saniye.ToString();
            dakikaLbl.Text = (dak).ToString();
            if (saniye == 59)
            {
                saniye = -1;
                dak += 1;

            }
        }

        private void timeLabel_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void MapButtonClick(object sender, EventArgs e) //default clickedButton beyaz seçilen takıma göre tıklanan buton renk değişir
        {
            int team;
            timer2.Enabled = false; 

            if (!gameStart) // oyun başlamadıysa return
            {
                return;
            }

            team = t1Btn.Checked ? 1 : 2;

            if (t1Btn.Checked)
            {
                t2Btn.Hide();
            }
            if (t2Btn.Checked)
            {
                t1Btn.Hide();
            }

            var clickedButton = (Button)sender;
            clickedButton.BackColor = Color.White;

            if (team == 1 && team != 2)
            {
                clickedButton.BackColor = Color.Blue;
            }
            else if (team != 2 && team != 1)
            {
                clickedButton.BackColor = Color.White;
            }
            else
            {
                clickedButton.BackColor = Color.Red;
            }

        }

        private void StartButtonClick(object sender, EventArgs e)
        {
            if (!gameStart) // oyun başlamadıysa return
            {
                return;
            }

            button25.Text = gameStart ? "BİTİR" : "BAŞLA";       
            timer1.Start();

        }

        private void oyunaBaslaBtn_Click(object sender, EventArgs e)
        {
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            map.ForEach(item => item.BackColor = Color.White);
        }

        private void oyunaBaslaBtn_Click_1(object sender, EventArgs e)
        {
        }

        private void t1Btn_CheckedChanged(object sender, EventArgs e)
        {
            selectedTeam = true;
        }

        private void t2Btn_CheckedChanged(object sender, EventArgs e)
        {
            selectedTeam = true;
        }

        private void button27_Click(object sender, EventArgs e) //GÖSTER BUTTONU
        {
            if(t1Btn.Checked) {
                t2Btn.Hide();
            }
            if (t2Btn.Checked)
            {
                t1Btn.Hide();
            }
            if (!selectedTeam)
            {
                return;
            }
            gameStart = true;
            //oyuna başla butonu gizlenir
            //random harita oluşturma başlangıcı
            List<Button> buttons = Controls.OfType<Button>().Where(b => b.Tag == "map").ToList(); // tüm butonlara erişebilmek için

            /*buttons.ForEach(x => x.Text = x.Name);*/ //textlerini görebilmek için önemsiz

            Random r = new Random();
            int range = 3; //her sıradaki buton sayısı
            int startIndex = 0; //başlangıç bu değişecek sürekli

            while (startIndex + 3 < buttons.Count + 1) //
            {
                map.Add(buttons[r.Next(startIndex, startIndex + range)]); //0 ile 3 (3 hariç) arasından herhangi bir butonu seçtik
                startIndex += range; // start indexi arttırdık artık bi sonraki satırda seçcek 1-3 3-6
            }

            map.ForEach(item => item.BackColor = Color.Red);

            //foreach (var item in map)         // HOCAYA SORULACAK NEDEN TEK TEK BOYAMIYO
            //{
            //     item.BackColor = Color.Red;

            //    System.Threading.Thread.Sleep(4000);

            //}

            //for (int i=0;i<buttons.Count;i++)
            //{
            //    map[i].BackColor = Color.Red;
            //    System.Threading.Thread.Sleep(5000);
            //}
            timer2.Interval = 5000;
            timer2.Enabled = true;
        }
    }
}
