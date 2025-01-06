using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personel_Yonetimi_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void listele()
        {
            List<EntityPersonel> PersonelList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PersonelList;
        }
        void temizle()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Ad = textBox2.Text;
            ent.Soyad = textBox3.Text;
            ent.Sehir = textBox4.Text;
            ent.Maas = short.Parse(textBox5.Text);
            ent.Gorev = textBox6.Text;
            LogicPersonel.LLPersonelEkle(ent);
            MessageBox.Show("personel eklendi");
            listele();
            temizle();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = int.Parse(textBox1.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
            MessageBox.Show("personel silindi");
            listele();
            temizle();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = int.Parse(textBox1.Text);
            ent.Ad = textBox2.Text;
            ent.Soyad = textBox3.Text;
            ent.Sehir = textBox4.Text;
            ent.Maas = short.Parse(textBox5.Text);
            ent.Gorev = textBox6.Text;
            LogicPersonel.LLPersonelGuncelle(ent);
            MessageBox.Show("personel güncellendi");
            listele();
            temizle();
        }
    }
}
