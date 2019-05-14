﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Adam_Asmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string[] tahminEdilecekler = new string[] { "televizyon", "araba", "uçak" };
        public string[] ipucu = new string[] { "dizi izleriz", "bir ulaşım aracı", "kuşlara benzer" };
        public char[] hatalar = new char[6];
        public int index = 0;


        // Tahmin edilecek olan kelimeyi form objesine ekle
        public string tahminEdilecek = "";
        // Boş bir karakter dizisini form objesine ekle
        public char[] tahminEdilmis = new char[100];
        // Oyun başladı
        public Boolean gameStarted = false;
        public int error = 0;

        /*
            Form1 load olduğunda tahminedilecek string formdan çekilir.
            Tahmin edilmişin tipini tanıplayıp tahmin edileceğin uzunluğu kadar karakter dizesi açılır.
            Döngü oluşurup integer değerinde +
        */
        private void Form1_Load(object sender, EventArgs e)
        {
            this.selectRandomQuestion();
        }

        private void kontrol_Click(object sender, EventArgs e)
        {
            if (!this.gameStarted)
            {
                MessageBox.Show("Lütfen oyunu başlat butonuna basınız..");
                return;
            }
            string dirtyInput = Regex.Replace(input.Text, @"/[a-zA-Z]+/g", "");
            if (dirtyInput.Length == 0)
            {
                MessageBox.Show("Lütfen bir karakter giriniz..");
                return;
            }
            char text = dirtyInput.ToLower()[0];

            // MessageBox.Show(input.Text);
            string tahminEdilecek = this.tahminEdilecek;
            // string tahminEdilecek = "Demo";


            char[] tahminEdilmis = this.tahminEdilmis;
            // char[] tahminEdilmis = "****";
            Boolean match = false;
            for (int i = 0; i < tahminEdilecek.Length; i++)
            {
                Console.WriteLine(tahminEdilecek[i]);
                if (tahminEdilecek[i] == text)
                {
                    match = true; 
                    tahminEdilmis[i] = text;
                } else
                {
                    hatalar[this.error % 6] = text;
                }
            }

            
            // Eğer girilen karakter,
            // Elimizdeki yazı ile eşleşmiyor ise.
            if (!match)
            {
                this.catchError();
                hatalarLabel.Text = string.Join(", ", hatalar);
            }

            result.Text = new string(tahminEdilmis);
            input.Text = "";
            // D***
            this.tahminEdilmis = tahminEdilmis;

            if (new string(tahminEdilmis) == tahminEdilecek)
            {
                MessageBox.Show("Alphonso'yu kurtardın, tebrikler!");
                // oyun bitti olarak set et.
                gameStarted = false;
                selectRandomQuestion();
                return;
            }
        }

        private void catchError()
        {
            this.error++;
            if (this.error == 7)
            {
                MessageBox.Show("Oyun bitti");
                // oyun bitti olarak set et.
                gameStarted = false;
                selectRandomQuestion();
                return;
            }
            // this.error sınıf değişkenini stringe çevir.
            string error = this.error.ToString();
            // - karakterini hata sayısı ile değiştir.
            picture.Image = Image.FromFile(@"C:\hang\-.png".Replace('-', error[0]));
        }

        private void selectRandomQuestion()
        {
            timerLabel.Text = "60";
            timer.Stop();

            // picture.Image = Image.FromFile(@"C:\hang\1.png");
            // tahmin edilecek olanı random olarak seç.
            Random random = new Random();
            int index = random.Next(0, this.tahminEdilecekler.Length);
            Console.Write(tahminEdilecekler[index]);

            this.tahminEdilecek = tahminEdilecekler[index];
            this.index = index;

            hint.Text = this.ipucu[this.index];

            string tahminEdilecek = this.tahminEdilecek;

            char[] tahminEdilmis = new char[tahminEdilecek.Length];
            for (int i = 0; i < tahminEdilecek.Length; i++)
            {
                tahminEdilmis[i] = '*';
            }
            this.tahminEdilmis = tahminEdilmis;

            result.Text = new string(tahminEdilmis);

            error = 0;
            hatalar = new char[6];
            hatalarLabel.Text = "Hatalı girilen karakterler: ";

        }

        private void start_Click(object sender, EventArgs e)
        {
            this.gameStarted = true;
            // zamanlayıcıyı başlat.
            // ....
            timerLabel.Text = "60";
            timer.Start();
            picture.Image = Image.FromFile(@"C:\hang\-.png".Replace('-', '0'));
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            int timeLeft = int.Parse(timerLabel.Text);
            timeLeft--;

            if (timeLeft == 0)
            {
               
                this.gameStarted = false;
                selectRandomQuestion();
                this.error = 5;
                catchError();

                MessageBox.Show("Zamanın doldu");

            }
            timerLabel.Text = timeLeft.ToString();
        }
    }
}






/*private void button1_Click(object sender, EventArgs e)
{
    pictureBox1.Image = Image.FromFile('C:\hang\2.png');
} */ 