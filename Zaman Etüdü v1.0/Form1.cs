using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Diagnostics;

namespace Zaman_Etüdü_v1._0
{
    public partial class Form1 : Form
    {
        #region Tanımlamalar

        string[] parçaismi = new string[20];
        int[] işlemsayısı = new int[20];
        Label[] label = new Label[20];
        TextBox[] textbox = new TextBox[20];
        TextBox[] no = new TextBox[20];
        TextBox[] işlemsayısı2 = new TextBox[20];
        TextBox[] süre = new TextBox[20];



        #endregion

        #region Metodlar

        public void textkur(TextBox[] txt)
        {
            txt[a3] = new TextBox();
            txt[a3].Name = "txt" + a3;
            txt[a3].Text = (a3+1).ToString();
            txt[a3].Location = new Point(x3, y3 +26);
            txt[a3].Size = new System.Drawing.Size(45, 26);
            panel2.Controls.Add(txt[a3]);
         
        }

        public void textkur2(TextBox[] txt)
        {
            txt[a3] = new TextBox();
            txt[a3].Name = "txt1" + a3;
            txt[a3].Text = comboBox1.Text; 
            txt[a3].Location = new Point(x4, y4 + 26);
            txt[a3].Size = new System.Drawing.Size(160, 26);
            panel2.Controls.Add(txt[a3]);

        }

        public void textkur3(TextBox[] txt)
        {
            txt[a3] = new TextBox();
            txt[a3].Name = "txt2" + a3;
            txt[a3].Text = sonuç.ToString();
            txt[a3].Location = new Point(x5, y5 + 26);
            txt[a3].Size = new System.Drawing.Size(70, 26);
            panel2.Controls.Add(txt[a3]);

        }

        #endregion 

       

        #region Değişkenler

        string ürünismi;
        int a1 = 0;
        int a2 = 0;

        int x1 = 12, y1 = -11;
        int x2 = 77, y2 = -18;

        int x3 = 3, y3 = -23;
        int x4 = 48, y4 = -23;
        int x5 = 208, y5 = -23;

        int sonuç = 0;

        string t;
        #endregion


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox2.Enabled = false;
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = ürünismi+" ÜRETİMİ";
            label8.Left = (groupBox2.ClientSize.Width - label8.Size.Width) / 2;
            parçaismi[a1] = textBox2.Text;
            işlemsayısı[a1] = int.Parse(textBox3.Text);
            groupBox2.Enabled = true;
            a1++;
            t = textBox2.Text;
            z=int.Parse(textBox3.Text);
            textBox3.Clear();
            textBox2.Clear();
            pictureBox2.BackColor = Color.Yellow;
            w1 = 0;
            comboBox1.Items.Add(t + " Parçası " + z + " Adet İşlem");
            comboBox1.Text = t + " Parçası " + z + " Adet İşlem";
            //timer1.Start();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ürünismi = textBox1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            c = 0;

            a2 = comboBox1.SelectedIndex;

            x1 = 12; y1 = -11;
            x2 = 77; y2 = -18;
            panel1.Controls.Clear();

            for (int i = 0; i < işlemsayısı[a2]; i++)
            {
                label[i] = new Label();
                label[i].Name = "lbl" + i;
                label[i].Text = "İşlem " + (i + 1);
                label[i].Location = new Point(x1, y1 + 35);
                label[i].AutoSize = true;
                panel1.Controls.Add(label[i]);

                textbox[i] = new TextBox();
                textbox[i].Name = "txt" + i;
                textbox[i].Text = "";
                textbox[i].Location = new Point(x2, y2 + 35);
                textbox[i].Size = new System.Drawing.Size(140, 26);
                panel1.Controls.Add(textbox[i]);
                y1 = y1 + 35;
                y2 = y2 + 35;
            }
        }

        int a3 = 0;
        int sonuç3 = 0;
        int z=0;

        
        private void button2_Click(object sender, EventArgs e)
        {
            sonuç = 0;
            sonuç3 = 0;

            a2 = comboBox1.SelectedIndex;

            for (int j = 0; j < işlemsayısı[a2]; j++)
            {
                sonuç += int.Parse(textbox[j].Text);
            }

            textkur(no);
            textkur2(işlemsayısı2);
            textkur3(süre);

            a3++;

            for (int i = 0; i < a3; i++)
            {
                sonuç3 += int.Parse(süre[i].Text);
            }

            textBox4.Text = sonuç3.ToString();
           
            y3 = y3 + 26;
            y4 = y4 + 26;
            y5 = y5 + 26;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text!="")
            {
                pictureBox2.BackColor = Color.White;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                pictureBox2.BackColor = Color.White;
            }
        }

        int w1 = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (w1 < 30)
            //{
            //    comboBox1.Text = t + " Parçası "+z+" Adet İşlem";
            //}

            //else
            //{
            //    timer1.Stop();
            //    comboBox1.Text = "";
            //}
            //w1++;
        }

        Stopwatch SW = new Stopwatch();

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Start();
            SW.Reset();
            SW.Start();
            

        }

      

        private void timer2_Tick(object sender, EventArgs e)
        {
           
            lblsüre.Text = SW.Elapsed.ToString();
        }

        int c = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            SW.Stop();
           
            lblsüre.Text = SW.Elapsed.ToString();
            timer2.Stop();
            textbox[c].Text = lblsüre.Text;
            c++;
        }
    }
}
