using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ValidarCampos(); // Llama a la función que marca en rojo los campos vacíos

            if (txtApellido.BackColor == Color.Red ||
                txtNombre.BackColor == Color.Red ||
                txtEdad.BackColor == Color.Red ||
                txtDireccion.BackColor == Color.Red)
            {
                MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                return;
            }
            txtResultado.Text = "Apellido y Nombre: " + txtApellido.Text + " " + txtNombre.Text + "\r\n" +
                        "Edad: " + txtEdad.Text + "\r\n" +
                        "Dirección: " + txtDireccion.Text;
        }
        private void ValidarCampos()
        {
            txtApellido.BackColor = Color.White;
            txtNombre.BackColor = Color.White;
            txtEdad.BackColor = Color.White;
            txtDireccion.BackColor = Color.White;

            if (txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
            }

            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
            }

            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
            }

            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < '0' || e.KeyChar > '9') // Solo permite números del 0 al 9
            {
                e.Handled = true; // Bloquea la entrada si no es un número
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            txtApellido.Text = txtApellido.Text.ToUpper();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            txtNombre.Text = txtNombre.Text.ToUpper();
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            txtDireccion.Text = txtDireccion.Text.ToUpper();
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtApellido.Text.Length >= 20)
            {
                e.Handled = true;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtNombre.Text.Length >= 20)
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}