﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Net;
using etechero_menu.Properties;

namespace etechero_menu
{
    public partial class Form1 : Form
    {

        //private bool revelar;
        private bool revelou;

        public Form1()
        {
            InitializeComponent();
          
            ladinho.Height = button1.Height;
            ladinho.Top = button1.Top;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void materialContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ladinho.Height = button1.Height;
            ladinho.Top = button1.Top;
            timer1.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (revelou)
            {
               // button1.Image = Resources.Collapse_Arrow_20px;
                panel5.Height += 10;
                if (panel5.Size == panel5.MaximumSize)
                {
                    timer1.Stop();
                    revelou = false;
                }
            }
            else
            {
              //  button5.Image = Resources.Expand_Arrow_20px;
                panel5.Height -= 10;
                if (panel5.Size == panel5.MinimumSize)
                {
                    timer1.Stop();
                    revelou = true;
                }
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
