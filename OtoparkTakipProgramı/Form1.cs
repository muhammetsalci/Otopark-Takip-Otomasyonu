using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OtoparkTakipProgramı
{
    public partial class Form1 : Form
    {
        Form3 f3 = new Form3();

        public Form1()
        {
            InitializeComponent();
        }
        //bütün formlarda kullanabilmek için bu şekilde diziler oluşturuyoruz.
        public static string[] konum1 = new string[21];
        public static string[] plaka1 = new string[21];
        public static string[] id1 = new string[21];
        public static string[] ad1 = new string[21];
        public static string[] soyad1 = new string[21];
        public static string[] cep1 = new string[21];
        public static string[] marka1 = new string[21];
        public static string[] model1 = new string[21];
        public static string[] renk1 = new string[21];
        public static string[] tc1 = new string[21];
        public static int i = 0;
        public static string[] parcala = new string[21];
        public static string[] dosya = new string[21];

        private void button1_Click(object sender, EventArgs e)
        {

            string yazi;

            string dosya_yolu = @".\veriler.txt"; //dosyanın konumu seçiyoruz.

            FileStream fs = new FileStream(dosya_yolu, FileMode.Open, FileAccess.Read); //dosyayı açıyoruz.

            StreamReader sw = new StreamReader(fs);



            yazi = sw.ReadLine(); //satırı yazi değişkenine atıyoruz.

            i = 0;

            for (int f = 0; f < 21; f++) //her satırı okumak için döngü oluşturuyoruz.
            {
                if (yazi == null) //yazi değeri eğer boşsa atlıyoruz.
                {
                    continue;
                }
                else //değilse yazdırıyoruz.
                {
                    parcala = yazi.Split('#'); //satırda # değerini görünce satırı bölüp parcala adlı dizinin elemanlarına atıyoruz.
                    id1[i] = parcala[0]; 
                    tc1[i] = parcala[1];
                    ad1[i] = parcala[2];
                    soyad1[i] = parcala[3];
                    cep1[i] = parcala[4];
                    plaka1[i] = parcala[5];
                    marka1[i] = parcala[6];
                    model1[i] = parcala[7];
                    renk1[i] = parcala[8];
                    konum1[i] = parcala[9];
                    //her bir elemanı isteilen dizilere atıyoruz.

                    yazi = sw.ReadLine(); //bir sonraki satırı okutuyoruz.
                    i++;
                }
            }

            for (int c = 0; c < 20; c++)
            {

                Form2.id[c] = Convert.ToInt32(id1[c]);

            }

            Form2.tc = tc1;
            Form2.ad = ad1;
            Form2.soyad = soyad1;
            Form2.cep = cep1;
            Form2.plaka = plaka1;
            Form2.marka = marka1;
            Form2.model = model1;
            Form2.renk = renk1;
            Form2.konum = konum1;
            //bilgieri form2 ye gönderiyoruz.
            Form2.i = i;


            fs.Close(); //dosyayı kapatıyoruz.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(".\\veriler.txt", FileMode.Append); //dosyayı oluşturuyoruz.
            StreamWriter sw = new StreamWriter(fs);

            for (int i = 0; i < 20; i++) //her bir satırı okutmak için döngü oluşturuyoruz.
            {
                if (Form2.veri[i] != null)
                {
                    sw.Write(Form2.veri[i] + "\n");
                }
            }
            sw.Flush();
            fs.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog(); //form2 yi açıyoruz.
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog(); //form3 ü açıyoruz.
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close(); //programı kapatıyoruz.
        }
    }
}
