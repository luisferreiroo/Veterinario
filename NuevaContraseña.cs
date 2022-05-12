using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinario
{
    public partial class NuevaContraseña : Form
    {
        Conexion conexion = new Conexion();
        public NuevaContraseña()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = textBox2.Text;
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
                textBox2.Text = text;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                textBox2.Text = text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
