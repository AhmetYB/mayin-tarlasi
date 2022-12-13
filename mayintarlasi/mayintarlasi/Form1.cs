using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mayintarlasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] mayinlar=new int[10];
        Random r = new Random();
        int btnno;
        int sure = 0;
       

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn.Name.Length==7)
            {
                btnno =Convert.ToInt32( btn.Name.Substring(6, 1));
                
            }
            else if (btn.Name.Length==8)
            {
                btnno = Convert.ToInt32(btn.Name.Substring(6, 2));
            }
            else
            {
                btnno = Convert.ToInt32(btn.Name.Substring(6, 3));
            }

            if (mayinlar.Contains(btnno))
            {
                btn.BackColor = Color.Red;
                timer1.Stop();
                sure = 0;
                MessageBox.Show("Oyun bitti. Puan="+label2.Text);
                
            }
            else
            {
                btn.BackColor = Color.Green;
            }
           
        }

        private void button101_Click(object sender, EventArgs e)
        {
            timer1.Start();
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.Gray;
                }
            }


            int sayac = 0,rasgelesayi;
            while (sayac<10)
            {
                rasgelesayi = r.Next(1,101);
                if (mayinlar.Contains(rasgelesayi)==false)
                {
                    mayinlar[sayac]=rasgelesayi;
                    sayac++;
                }
                
            }
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.BackColor = Color.Gray;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure++;
            label2.Text = sure.ToString();

        }
    }
}
