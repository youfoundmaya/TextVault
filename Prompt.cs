﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextVault
{
    public partial class Prompt : Form
    {
        public string a;
        public int i;
        public Prompt()
        {
            InitializeComponent();
            a = "";
            i = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            a = textBox1.Text;
            i = 0;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i = 1;
            Close();
        }

    }
}
