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
    public partial class level3 : Form
    {
        int dak = 0;
        int saniye = 0;
        bool gameStart = false;
        bool selectedTeam = false;    
        
        private bool isTimerRunning = false;
        private bool isButtonChanged = false;
        private bool isStartButtonClicked = false;
        private bool levelEnd = false;
        private bool surReady = false;
        private bool boyamaOpen = false;
        private bool isButton27Clicked = false;

        List<Button> map = new List<Button>();
        List<Button> mapClone = new List<Button>();
        public level3()
        {
            InitializeComponent();
        }
        private void level3_Load(object sender, EventArgs e)
        {
            t1Btn.Text = MainMenu.player1Name;
            t2Btn.Text = MainMenu.player2Name;
        }     
        private void button27_Click(object sender, EventArgs e) //GÖSTER BUTTON
        {
            if (isButton27Clicked)
            {
                return;  // 1 kere göstere bastıysan bidaha basamıyosun 
            }

            if (!selectedTeam)
            {
                return;
            }
            t1Btn.Enabled = false;
            t2Btn.Enabled = false;
            gameStart = true;
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

            //map.ForEach(item => item.BackColor = Color.Red);

            foreach (var item in map)
            {
                item.BackColor = Color.Green;
            }

            timer2.Interval = 4000; //4 saniye durcak
            timer2.Enabled = true;
            isButton27Clicked = true;
            mapClone.AddRange(map);
        }
        private void button26_Click(object sender, EventArgs e) //TESLİM OLMA BUTTON
        {
            if (!surReady)
            {
                return;
            }

            if (!gameStart)
            {
                return;
            }

            if (isStartButtonClicked)
            {
                return;
            }

            timer1.Stop();
            MessageBox.Show("TESLİM OLDUN");
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            saniye = saniye + 1;
            saniyeLbl.Text = saniye.ToString();
            dakikaLbl.Text = dak.ToString();
            if (saniye == 59)
            {
                saniye = -1;
                dak += 1;
            }
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            map.ForEach(item => item.BackColor = Color.White);
        } //BOYANAN ALANI ESKİ RENGİNE ÇEVİRME
        private void button25_Click(object sender, EventArgs e) //BAŞLA BUTTON
        {
            if (!gameStart)
            {
                return;
            }

            if (isStartButtonClicked)
            {
                return;
            }

            if (!isButtonChanged)
            {
                button25.Text = "BİTİR";
                isButtonChanged = true;
                surReady = true;
                boyamaOpen = true;
            }

            if (isTimerRunning)
            {
                // Timer zaten çalışıyorsa durdur
                timer1.Stop();
                isTimerRunning = false;
                isStartButtonClicked = true;// Button ismi "BİTİR" ise tıklanma özelliği biter

            }
            else
            {
                // Timer çalışmıyorsa başlat
                timer1.Start();
                isTimerRunning = true;
            }
        }
        private void t1Btn_CheckedChanged(object sender, EventArgs e)
        {
            selectedTeam = true;
        } //player1 seçme
        private void t2Btn_CheckedChanged(object sender, EventArgs e)
        {
            selectedTeam = true;
        } //player2 seçme
        private void MapButtonClick(object sender, EventArgs e) //seçilen takıma göre tıklanan buton renk değişir
        {
            int team;
            timer2.Enabled = false;

            if (!gameStart) // oyun başlamadıysa return
            {
                return;
            }
            if (!boyamaOpen) { return; } //Boymaya başlamak için başlata bas

            team = t1Btn.Checked ? 1 : 2;

            var clickedButton = (Button)sender;
            clickedButton.BackColor = Color.White;

            if (mapClone.First() == clickedButton) //tıklanan dizinin ilk elemanı mı kontrol
            {
                mapClone.Remove(clickedButton); //ilk elemanı siliyoruz diğeri ilk eleman oluyo kuyruk mantığı
            }
            else
            {
                MessageBox.Show("Kaybettiniz");
                timer1.Stop();
                return;
            }

           

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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    } 
}
