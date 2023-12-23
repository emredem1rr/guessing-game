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
    public partial class level2 : Form
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
        private bool bitirActive = false;
        private bool gosterEnd = false;
        List<Button> map = new List<Button>();
        List<Button> mapClone = new List<Button>();
        public level2(List<Player> players)
        {
            InitializeComponent();
            this.Players = players;
        }

        public level2()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currentPlayer = Players[0];
            currentPlayerLabel.Text = currentPlayer.Name;
        }      
        private void timer1_Tick(object sender, EventArgs e) //süre sayac yeri
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
        private void timeLabel_Click(object sender, EventArgs e)
        {
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }        
        private void StartButtonClick(object sender, EventArgs e) // BAŞLA BUTTON
        {

            List<Button> buttons = Controls.OfType<Button>().Where(b => b.Tag == "map").ToList(); // tüm butonlara eriştik
            buttons.ForEach(b => b.Enabled = true);//buttonun basılabilmesini açtık

            if (isStartButtonClicked)
            {
                return;
            }
            if (!gosterEnd) { return; }
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
                if (!bitirActive) { return; } //bitir aktifleştiys
                timer1.Stop();
                isTimerRunning = false;
                isStartButtonClicked = true;// Button ismi "BİTİR" ise tıklanma özelliği biter
                levelEnd = true;
            }
            else
            {
                // Timer çalışmıyorsa başlat
                timer1.Start();
                isTimerRunning = true;
            }
            
        } 
        private void button27_Click(object sender, EventArgs e) //GÖSTER BUTTONU -----------------
        {
            if (isButton27Clicked)
            {
                return;  // 1 kere göstere bastıysan bidaha basamıyosun 
            }

            List<Button> buttons = Controls.OfType<Button>().Where(b => b.Tag == "map").ToList(); // tüm butonlara erişebilmek için
            buttons.ForEach(b => b.Enabled = false); //buttonun basılabilmesini kapadık

            Random r = new Random();
            int range = 3; //her sıradaki buton sayısı
            int startIndex = 0; //başlangıç bu değişecek sürekli

            while (startIndex + 3 < buttons.Count + 1) //
            {
                map.Add(buttons[r.Next(startIndex, startIndex + range)]); //0 ile 3 (3 hariç) arasından herhangi bir butonu seçtik
                startIndex += range; // start indexi arttırdık artık bi sonraki satırda seçcek 1-3 3-6
            }

            foreach (var item in map)
            {
                item.BackColor = Color.Green;
            }
            
            timer2.Interval = 2000; //2 saniye durcak
            timer2.Enabled = true;
            isButton27Clicked = true;
            mapClone.AddRange(map);
        }
        private void oyunaBaslaBtn_Click(object sender, EventArgs e)
        {
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            map.ForEach(item => item.BackColor = Color.White);
            List<Button> buttons = Controls.OfType<Button>().Where(b => b.Tag == "map").ToList(); // tüm butonlara eriştik         
            buttons.ForEach(b => b.Enabled = true); //buttonların boyanması kapandıgında başlata basma açılır
            gosterEnd = true;
        } //BOYANAN ALANI ESKİ RENGİNE ÇEVİRME
        private void oyunaBaslaBtn_Click_1(object sender, EventArgs e)
        {
        }
        private void t1Btn_CheckedChanged(object sender, EventArgs e)
        {         
            
        } 
        private void t2Btn_CheckedChanged(object sender, EventArgs e)
        {           
            
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
        private void nextLvl_Click(object sender, EventArgs e)
        {
            if (!levelEnd)
            {
                return;
            }
            level3 level3Form = new level3(this.Players);

            // oyun formu gösterme
            level3Form.Show();
            // bu formu gizleme
            this.Hide();
        }
        private void MapButtonClick(object sender, EventArgs e) //seçilen takıma göre tıklanan buton renk değişir
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
            bitirActive = true;
        }

        private void ResetMap() //map reset
        {
            List<Button> buttons = Controls.OfType<Button>().Where(b => b.Tag == "map").ToList(); // tüm butonlara eriştik
            buttons.ForEach(b => b.BackColor = Color.White); //beyaz yaptık
            CreateMap(buttons);
        }

        private void CreateMap(List<Button> buttons)
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

        private void saniyeLbl_Click(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            List<Button> buttons = Controls.OfType<Button>().Where(b => b.Tag == "map").ToList(); // tüm butonlara eriştik
            buttons.ForEach(b => b.Enabled = true);
        }
    }
}
