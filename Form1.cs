using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema3Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (sender == this)
            {
                this.Text = e.Location.ToString();

            }
            else
            {
                int posicionX = e.Location.X + ((Button)sender).Left;
                int posicionY = e.Location.Y + ((Button)sender).Top;
                this.Text = $"{{X={posicionX}; Y={posicionY}}}";
            }
        }

        private void SalirForm(object sender, EventArgs e)
        {
            this.Text = "Mouse Tester";
        }

        private void Botones(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.button1.BackColor = SystemColors.ControlDark;

            }
            if (e.Button == MouseButtons.Right)
            {
                this.button2.BackColor = SystemColors.ControlDark;
            }
        }

        private void Soltar(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.button1.BackColor = SystemColors.Control;
            }

            if(e.Button == MouseButtons.Right)
            {
                this.button2.BackColor = SystemColors.Control;
            }
        }

        private void Tecla(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                this.Text = "Mouse Tester";
            } 
            else
            {
                this.Text = e.KeyCode.ToString();
            }
        }

        private void Cerrar(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir?", "Mouse Tester", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
