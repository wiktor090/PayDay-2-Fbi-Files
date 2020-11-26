using System;
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
    public partial class Fbi_Servers_Login : Form
    {
        public Fbi_Servers_Login()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new SuspectLoadoutOkno().Show();
        }

        private void Fbi_Servers_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Fbi_Servers_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
