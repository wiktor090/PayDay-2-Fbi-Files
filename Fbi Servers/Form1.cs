﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fbi_Servers
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = "payday2";
            if (haslo.Text == password)
            {
                Console.WriteLine("Good");
                MessageBox.Show("Good Password", "Good", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new Fbi_Servers_Login().Show();
                this.Hide();
            }
            else
            {
                DialogResult result = MessageBox.Show("Wrong Password", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }

        private void haslo_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

