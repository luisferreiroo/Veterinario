using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Veterinario
{
    public partial class VentanaLogin : Form
    {
        Conexion conexion = new Conexion();
        public VentanaLogin()
        {
            InitializeComponent();
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Contraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void boton_Entrar_Click(object sender, EventArgs e)
        {
            if (conexion.loginVeterinario(Usuario.Text, Contraseña.Text))
            {
                this.Hide();
                VentanaPrincipal v = new VentanaPrincipal();
                v.Show();
            }
            else
            {
                MessageBox.Show("EL USUARIO O LA CONTRASEÑA SON INCORRECTOS");
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = Contraseña.Text;
            if (checkBox1.Checked)
            {
                Contraseña.UseSystemPasswordChar = false;
                Contraseña.Text = text;

            }
            else
            {
                Contraseña.UseSystemPasswordChar = true;
                Contraseña.Text = text;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro r = new Registro();
            r.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevaContraseña nc = new NuevaContraseña();
            nc.Show();
            this.Hide();
            InitializeComponent();
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.BackColor = Color.Transparent;
        }

    }
    }

