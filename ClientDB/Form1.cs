﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientDB;

namespace ClientDB
{
    public partial class Form1 : Form
    {
        private ClientDB CDB;

        public Form1()
        {
            InitializeComponent();
            CDB = new ClientDB("Do Nothing Pty Ltd");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(!CDB.AddClient(ClientNameTextBox.Text))
            {
                MessageBox.Show("Cannot add this client!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}