using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOccasAuto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Connection();
        }

        public void Connection()
        {
            //cnx bd 
            MySqlConnection cnx = new MySqlConnection("SERVER=localhost;DATABASE=bdOccasion;UID=root;");
            cnx.Open();
        }

        private void crtSelcetion_SelectedIndexChanged(object sender, EventArgs e)
        {
            


        }
    }
}
