using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {

        List<Kart> oyuncukartlist = new List<Kart>()
        {
            new Kart(){Value=0, Name="null",Image="null"}
        };
        List<Kart> kurpiyerkartlist = new List<Kart>()
        {
            new Kart(){Value=0, Name="null",Image="null"}
        };

        int oyuncukartsayısı = 0;
        int kurpiyerkartsayısı = 0;
        Random random = new Random();
        List<int> Kartkullan = new List<int>();
        List<PictureBox> kurpiyerbox = new List<PictureBox>();
        List<PictureBox> oyuncubox = new List<PictureBox>();

        List<Kart> Kartçek = new List<Kart>()   
        {
                new Kart() { Value  = 2, Name = "Two Spades", Image = "2S.png" },
                new Kart() { Value = 3, Name = "Three Spades", Image = "3S.png"},
                new Kart() { Value = 4, Name =  "Four Spades", Image = "4S.png"},
                new Kart() { Value = 5, Name = "Five Spades", Image = "5S.png" },
                new Kart() { Value = 6, Name = "Six Spades", Image = "6S.png" },
                new Kart() { Value = 7, Name = "Seven Spades", Image = "7S.png" },
                new Kart() { Value = 8, Name = "Eight Spades", Image = "8S.png" },
                new Kart() { Value = 9, Name = "Nine Spades", Image = "9S.png" },
                new Kart() { Value = 10, Name = "Ten Spades", Image = "10S.png" },
                new Kart() { Value = 10, Name = "Jack Spades", Image = "JS.png" },
                new Kart() { Value = 10, Name = "Queen Spades", Image = "QS.png" },
                new Kart(){ Value = 10, Name = "King Spades", Image = "KS.png" },
                new Kart(){ Value = 11, Name = "Ace Spades", Image = "AS.png" },



                new Kart() { Value  = 2, Name = "Two Diamonds", Image = "2D.png" },
                new Kart() { Value = 3, Name = "Three Diamonds", Image = "3D.png" },
                new Kart() { Value = 4, Name =  "Four Diamonds", Image = "4D.png"},
                new Kart() { Value = 5, Name = "Five Diamonds", Image = "5D.png" },
                new Kart() { Value = 6, Name = "Six Diamonds", Image = "6D.png" },
                new Kart(){ Value = 7, Name = "Seven Diamonds", Image = "7D.png" },
                new Kart() { Value = 8, Name = "Eight Diamonds", Image = "8D.png" },
                new Kart() { Value = 9, Name = "Nine Diamonds", Image = "9D.png" },
                new Kart() { Value = 10, Name = "Ten Diamonds", Image = "10D.png" },
                new Kart() { Value = 10, Name = "Jack Diamonds", Image = "JD.png" },
                new Kart() { Value = 10, Name = "Queen Diamonds", Image = "QD.png" },
                new Kart(){ Value = 10, Name = "King Diamonds", Image = "KD.png" },
                new Kart(){ Value = 11, Name = "Ace Diamonds", Image = "AD.png" },



                new Kart() { Value  = 2, Name = "Two Clubs", Image = "2C.png" },
                new Kart() { Value = 3, Name = "Three Clubs", Image = "3C.png" },
                new Kart() { Value = 4, Name =  "Four Clubs", Image = "4C.png"},
                new Kart() { Value = 5, Name = "Five Clubs", Image = "5C.png" },
                new Kart() { Value = 6, Name = "Six Clubs", Image = "6C.png" },
                new Kart(){ Value = 7, Name = "Seven Clubs", Image = "7C.png" },
                new Kart() { Value = 8, Name = "Eight Clubs", Image = "8C.png" },
                new Kart() { Value = 9, Name = "Nine Clubs", Image= "9C.png" },
                new Kart() { Value = 10, Name = "Ten Clubs", Image = "10C.png" },
                new Kart() { Value = 10, Name = "Jack Clubs", Image = "JC.png" },
                new Kart() { Value = 10, Name = "Queen Clubs", Image = "QC.png" },
                new Kart(){ Value = 10, Name = "King Clubs", Image = "KC.png" },
                new Kart(){ Value = 11, Name = "Ace Clubs", Image = "AC.png" },



                new Kart() { Value  = 2, Name = "Two Hearts", Image = "2H.png" },
                new Kart() { Value = 3, Name = "Three Hearts", Image = "3H.png" },
                new Kart() { Value = 4, Name =  "Four Hearts", Image = "4H.png"},
                new Kart() { Value = 5, Name = "Five Hearts", Image = "5H.png" },
                new Kart() { Value = 6, Name = "Six Hearts", Image = "6H.png" },
                new Kart(){ Value = 7, Name = "Seven Hearts", Image = "7H.png" },
                new Kart() { Value = 8, Name = "Eight Hearts", Image = "8H.png" },
                new Kart() { Value = 9, Name = "Nine Hearts", Image = "9H.png" },
                new Kart() { Value = 10, Name = "Ten Hearts", Image = "10H.png" },
                new Kart() { Value = 10, Name = "Jack Hearts", Image = "JH.png" },
                new Kart() { Value = 10, Name = "Queen Hearts", Image = "QH.png" },
                new Kart(){ Value = 10, Name = "King Hearts", Image = "KH.png" },
                new Kart(){ Value = 11, Name = "Ace Hearts", Image = "AH.png" }
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            resetGame();
        }

        private void btnbaşla_Click(object sender, EventArgs e)
        {
            if (oyuncukartsayısı>0)
            {
                     
            }
            else
            {
                // oyuncu kart çekme
                oyuncukartsayısı = 0;
                kurpiyerkartsayısı = 0;

                int randomkart = RandomKart();
                Kart kart1 = Kartçek[randomkart];
                Kartkullan.Add(randomkart);

                int randomkart2 = RandomKart();
                while (Kartkullan.Contains(randomkart2))
                {
                    randomkart2 = RandomKart();
                }
                randomkart2 = 1 * randomkart2;
                Kart kart2 = Kartçek[randomkart2];
                Kartkullan.Add(randomkart2);

                oyuncukartlist.Add(kart1);
                oyuncukartlist.Add(kart2);

                pictureBox1.ImageLocation = kart1.Image;
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;

                pictureBox2.ImageLocation = kart2.Image;
                pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;


                // banka kart 

                int randomkart3 = RandomKart();
                while (Kartkullan.Contains(randomkart3))
                {
                    randomkart3 = RandomKart();
                }
                randomkart3 = 1 * randomkart3;
                Kart kart3 = Kartçek[randomkart3];
                Kartkullan.Add(randomkart3);
                kurpiyerkartlist.Add(kart3);

                pictureBox4.ImageLocation = kart3.Image;
                pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;

                OyuncuKartToplamı();

                if (oyuncukartsayısı == 21)
                {
                    
                    MessageBox.Show("Kazandınızzz...", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    resetGame();
                }
            }
        }
        private int RandomKart()
        {
            int randomkart;
            randomkart = random.Next(0, Kartçek.Count);
            return randomkart;
        }
        private void OyuncuKartToplamı()
        {
            oyuncukartsayısı = 0;
            for (int i = 0; i < oyuncukartlist.Count; i++)
            {
                oyuncukartsayısı += oyuncukartlist[i].Value;

            }
            if (oyuncukartsayısı > 21)
            {
                foreach (Kart item in oyuncukartlist)
                {
                    if (item.Value == 11)
                    {
                        oyuncukartsayısı -= 10;
                        if (oyuncukartsayısı <= 21)
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void KurpiyerKartSayısı()
        {
            kurpiyerkartsayısı = 0;
            for (int i = 0; i < kurpiyerkartlist.Count; i++)
            {
                kurpiyerkartsayısı += kurpiyerkartlist[i].Value;

            }
            if (kurpiyerkartsayısı > 21)
            {
                foreach (Kart item in kurpiyerkartlist)
                {
                    if (item.Value == 11)
                    {
                        kurpiyerkartsayısı -= 10;
                        if (kurpiyerkartsayısı <= 21)
                        {
                            break;
                        }
                    }
                }
            }
        }
        private void resetGame()
        {
            displayCardBack(pictureBox1);
            displayCardBack(pictureBox2);
            displayCardBack(pictureBox4);
            foreach (PictureBox pb in oyuncubox)
            {
                this.Controls.Remove(pb);
            }
            oyuncubox = new List<PictureBox>();
            foreach (PictureBox pb in kurpiyerbox)
            {
                this.Controls.Remove(pb);
            }
            kurpiyerbox = new List<PictureBox>();

            oyuncukartsayısı = 0;
           kurpiyerkartsayısı = 0;
            oyuncukartlist.Clear();
            kurpiyerkartlist.Clear();
            Kartkullan.Clear();
        }
        private void displayCardBack(PictureBox picturebox)
        {
            picturebox.ImageLocation = "b1fv.png";
            picturebox.SizeMode = PictureBoxSizeMode.AutoSize;
        }
        private void btnkartçek_Click(object sender, EventArgs e)
        {
            if (oyuncukartsayısı==0)
            {
                
            }
            else
            {
                if (oyuncukartsayısı>50)
                {


                }
                else
                {
                    oyuncukartsayısı = 0;
                    int randomkart = RandomKart();
                    Kart kart1 = Kartçek[randomkart];
                    Kartkullan.Add(randomkart);


                    if (Kartkullan.Contains(randomkart))
                    {
                        randomkart = RandomKart();
                    }
                    else
                    {
                        randomkart = 1 * randomkart;
                    }

                    // oyuncuya yeni kart
                    PictureBox p3 = new PictureBox();
                    p3.Width = 71;
                    p3.Height = 96;
                    p3.Location = new Point(154 + 77 + oyuncubox.Count * 77, 137);
                    p3.ImageLocation = kart1.Image;
                    p3.SizeMode = PictureBoxSizeMode.AutoSize;
                    this.Controls.Add(p3);
                    oyuncubox.Add(p3);
                    oyuncukartlist.Add(kart1);
                    OyuncuKartToplamı();

                    if (oyuncukartsayısı > 21)
                    {
                        
                        MessageBox.Show("Kaybettiniz Kartınız 21 den büyük", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resetGame();
                    }
                    else if (oyuncukartsayısı == 21)
                    {
                       
                        MessageBox.Show("Kazandınızz Tebrikler..", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        resetGame();
                    }




                }
            }
        }
        private void btnreset_Click(object sender, EventArgs e)
        {
            resetGame();
        }
        // oyuncu dur
        private void btndur_Click(object sender, EventArgs e)
        {
            if (oyuncukartsayısı==0)
            {


            }
            KurpiyerKartSayısı();

            // eger oyuncu durusa kurpıyer devam eder
            while (kurpiyerkartsayısı<=16)
            {
                int randomkart = RandomKart();
                Kart kart1 = Kartçek[randomkart];
                Kartkullan.Add(randomkart);

                if (Kartkullan.Contains(randomkart))
                {
                    randomkart = RandomKart();
                }
                else
                {
                    randomkart = 1 * randomkart;
                }

                // oyuncuya yeni kart
                PictureBox p4 = new PictureBox();
                p4.Width = 71;
                p4.Height = 96;
                p4.Location = new Point(154 + kurpiyerbox.Count * 77, 12);
                p4.ImageLocation = kart1.Image;
                p4.SizeMode = PictureBoxSizeMode.AutoSize;
                this.Controls.Add(p4);
                kurpiyerbox.Add(p4);
                kurpiyerkartlist.Add(kart1);
                KurpiyerKartSayısı();

            }
            if (kurpiyerkartsayısı > 21)
            {
               
                MessageBox.Show("Oyuncu Kazandı!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            }
            else if (kurpiyerkartsayısı==oyuncukartsayısı)
            {
                MessageBox.Show("Berabere!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            }
            else if (oyuncukartsayısı <=kurpiyerkartsayısı)
            {
                
                MessageBox.Show("Kurpiyer Kazandı", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            }
            else
            {
              
                MessageBox.Show("Oyuncu Kazandı!!!!", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resetGame();
            }
        }
    }
}
