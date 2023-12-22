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
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;

namespace WindowsFormsApp8
{
    public partial class Level1Form : Form
    {
        List<Player> Players = new List<Player>();
        Player currentPlayer;

        int dak = 0;
        int saniye = 0;
        bool gameStart = false;


        private bool isTimerRunning = false;
        private bool isButtonChanged = false;
        private bool isStartButtonClicked = false;
        private bool levelEnd = false;
        private bool surReady = false;
        private bool boyamaOpen = false;
        private bool isButton27Clicked = false;

        List<Button> map = new List<Button>();
        List<Button> mapClone = new List<Button>();

        public Level1Form(List<Player> players)
        {
            InitializeComponent();
            this.Players = players;
        }

        private void Level1_Load(object sender, EventArgs e)
        {
            currentPlayer = Players[0];
            currentPlayerLabel.Text = currentPlayer.Name;
        }

        private void timer1_Tick(object sender, EventArgs e) //SÜRE SAYAÇ
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

        private void timer2_Tick(object sender, EventArgs e) //BOYANAN ALANI ESKİ RENGİNE ÇEVİRME
        {
            map.ForEach(item => item.BackColor = Color.White);
            List<Button> buttons = Controls.OfType<Button>().Where(b => b.Tag == "map").ToList(); // tüm butonlara eriştik
            buttons.ForEach(b => b.Enabled = true); //buttonların boyanması kapandıgında başlata basma açılır
        }

        private void StartButtonClick(object sender, EventArgs e) // BAŞLA BUTTON
        { 
            List<Button> buttons = Controls.OfType<Button>().Where(b => b.Tag == "map").ToList(); // tüm butonlara eriştik
            buttons.ForEach(b => b.Enabled = true);//buttonun basılabilmesini açtık

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
                isStartButtonClicked = true; // Button ismi "BİTİR" ise tıklanma özelliği biter
                levelEnd = true;
            }
            else
            {
                // Timer çalışmıyorsa başlat
                timer1.Start();
                isTimerRunning = true;
            }

        }
        //bu bir butona bağlı olmamalı, map generation otomatik olmalı oyuncu değiştiğinde falan
        private void MapGeneration(object sender, EventArgs e) //GÖSTER BUTTON
        {
            if (isButton27Clicked)
            {
                return;  // 1 kere göstere bastıysan bidaha basamıyosun 
            }

            //random harita oluşturma başlangıcı
            List<Button> buttons = Controls.OfType<Button>().Where(b => b.Tag == "map").ToList(); // tüm butonlara erişebilmek için
            buttons.ForEach(b => b.Enabled = false); //buttonun basılabilmesini kapadık
            Random r = new Random();
            int range = 3; //her sıradaki buton sayısı
            int startIndex = 0; //başlangıç bu değişecek sürekli

            while (startIndex + range < buttons.Count + 1) //
            {
                map.Add(buttons[r.Next(startIndex, startIndex + range)]); //0 ile 3 (3 hariç) arasından herhangi bir butonu seçtik
                startIndex += range; // start indexi arttırdık artık bi sonraki satırda seçcek 1-3 3-6               
            }

            foreach (var item in map)
            {
                item.BackColor = Color.Green;
            }

            timer2.Interval = 3000; //3 saniye durcak
            timer2.Enabled = true;
            isButton27Clicked = true;
            mapClone.AddRange(map);
        }
        private void button26_Click(object sender, EventArgs e) //TESLİM OLMA BUTTON
        {
            if (!surReady)
            {
                return;
            }//teslim olma buttonu aktifleştirme

            if (!gameStart)
            {
                return;
            }//başlaya tıklanmadan teslim olunmaz

            if (isStartButtonClicked)
            {
                return;
            } //tıklandıysa bidaha tıklanamaz
            timer1.Stop();
            MessageBox.Show("TESLİM OLDUN");
        }
        private void nextLvl_Click(object sender, EventArgs e) //NEXT LEVEL 
        {
            if (!levelEnd)
            {
                return;
            }
            level2 level2 = new level2();

            // oyun formu gösterme
            level2.Show();
            // bu formu gizleme
            this.Hide();
        }
        private void t1Btn_CheckedChanged(object sender, EventArgs e) //player1 seçme
        {

        }
        private void t2Btn_CheckedChanged(object sender, EventArgs e) //player2 seçme
        {

        }
        private void button24_Click(object sender, EventArgs e)
        {

        }
        private void MapButtonClick(object sender, EventArgs e) //seçilen takıma göre boyama
        {
            int team;
            timer2.Enabled = false;


            List<Button> buttons = Controls.OfType<Button>().Where(b => b.Tag == "map").ToList(); // tüm butonlara eriştik
            buttons.ForEach(b => b.Enabled = true); //buttonun basılabilmesini açtık

            if (!boyamaOpen) { return; } //Boymaya başlamak için başlata bas

            team = currentPlayer.Name == Players.First().Name ? 1 : 2;

            var clickedButton = (Button)sender;
            clickedButton.BackColor = Color.White;

            if (team == 1)
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

            if (mapClone.First() == clickedButton) //tıklanan dizinin ilk elemanı mı kontrol
            {
                mapClone.Remove(clickedButton); //ilk elemanı siliyoruz diğeri ilk eleman oluyo kuyruk mantığı
            }
            else //yanlış bilirse resetliyoruz
            {
                ResetMap();
            }
        }

        private void ResetMap() // MAP RESETLEME
        {
            List<Button> buttons = Controls.OfType<Button>().Where(b => b.Tag == "map").ToList(); // tüm butonlara eriştik
            buttons.ForEach(b => b.BackColor = Color.White); //beyaz yaptık
            CreateMap(buttons);       
        }

        private void CreateMap(List<Button> buttons) //YENİDEN MAP YAPMA
        {
            this.map.Clear();
            mapClone.Clear();        
            buttons.ForEach(b => b.Enabled = false); //yeniden yaparken boyama işlemini iptal etme
            Random r = new Random();
            int range = 3; 
            int startIndex = 0; 

            while (startIndex + range < buttons.Count + 1) 
            {
                map.Add(buttons[r.Next(startIndex, startIndex + range)]); 
                startIndex += range;        
            }

            foreach (var item in map)
            {
                item.BackColor = Color.Green;
            }

            timer2.Interval = 3000;
            timer2.Enabled = true;
            timer3.Interval = 3000; 
            timer3.Enabled = true;
            mapClone.AddRange(map);
        }

        private void currentPlayerLabelPrefix_Click(object sender, EventArgs e)
        {

        }

        private void dakikaLbl_Click(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {       
            List<Button>buttons = Controls.OfType<Button>().Where(b => b.Tag == "map").ToList(); // tüm butonlara eriştik
            buttons.ForEach(b => b.Enabled = true);
        }
    }
}
