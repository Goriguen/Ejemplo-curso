using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemploGrafico
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrueba1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("La fecha seleccionada es: " + dtpFecha.Value.ToString("ddd/dd/MMMM/yyyy"));
            if (txtbPrueba.Text == "")
                txtbPrueba.BackColor = Color.Red;
            else
                txtbPrueba.BackColor = System.Drawing.SystemColors.Control;
        }

        private void btnPrueba2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La fecha seleccionada es: " + monthCalFecha.SelectionStart.ToString("ddd/dd/MMMM/yyyy"));

        }

        private void lblEvento_MouseMove(object sender, MouseEventArgs e)
        {
            lblEvento.BackColor = Color.Cyan;
            lblEvento.Cursor = Cursors.Hand;
        }

        private void lblEvento_MouseLeave(object sender, EventArgs e)
        {
            lblEvento.BackColor = System.Drawing.SystemColors.Control;
            lblEvento.Cursor = Cursors.Arrow;
        }

        private void txtbPrueba_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbPrueba_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtbPrueba.Text == "")
                txtbPrueba.BackColor = Color.Red;
            else
                txtbPrueba.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtb2Prueba_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtb2Prueba.Text.Length + " Caracteres");
        }
    }
}
