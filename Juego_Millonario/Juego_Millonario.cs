using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego_Millonario
{
    public partial class Juego_Millonario : Form
    {
        public Juego_Millonario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            R_1.BackColor = Color.Red;
            R_Correcta.BackColor = Color.LightGreen;
            MessageBox.Show("Respuesta Incorrecta.");
            R_2.Enabled = false;
            R_3.Enabled = false;
            R_Correcta.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            R_2.BackColor = Color.Red;
            R_Correcta.BackColor = Color.LightGreen;
            MessageBox.Show("Respuesta Incorrecta.");
            R_1.Enabled = false;
            R_3.Enabled = false;
            R_Correcta.Enabled = false;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            R_3.BackColor = Color.Red;
            R_Correcta.BackColor = Color.LightGreen;
            MessageBox.Show("Respuesta Incorrecta.");
            R_2.Enabled = false;
            R_1.Enabled = false;
            R_Correcta.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            R_Correcta.BackColor = Color.LightGreen;
            MessageBox.Show("Felicidades, Respuesta Correcta.");
            R_2.Enabled = false;
            R_3.Enabled = false;
            R_1.Enabled = false;
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            R_2.Enabled = false;
            R_3.Enabled = false;
        }
    }
}
