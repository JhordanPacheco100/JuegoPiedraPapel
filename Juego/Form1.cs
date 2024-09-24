using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juego
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Usuario;
        string pc;
        string resourcesPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\Resources\"));
        // Método para cargar una imagen
        private void CargarImagenUsuario(string seleccionUsuario)
        {
            string fullPath = Path.Combine(resourcesPath, $"{seleccionUsuario}.png");
            pictureBoxUsuario.Image = Image.FromFile(fullPath);
            Usuario = seleccionUsuario;
            textBoxPantalla.Text = seleccionUsuario;
        }
        private void CargarImagenPC(string seleccionPC)
        {
            string fullPathPC = Path.Combine(resourcesPath, $"{seleccionPC}.png");
            pictureBoxPC.Image = Image.FromFile(fullPathPC);
            pc = seleccionPC;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void buttonPiedra_Click(object sender, EventArgs e)
        {
            CargarImagenUsuario("Piedra");
        }

        private void buttonPapel_Click(object sender, EventArgs e)
        {
            CargarImagenUsuario("Papel");
        }

        private void buttonTigera_Click(object sender, EventArgs e)
        {
            CargarImagenUsuario("Tigera");
        }

        private void buttonComenzar_Click(object sender, EventArgs e)
        {
            Random X = new Random();
            int NUM = X.Next(1, 100);
            if (NUM >= 0 && NUM <= 30)
            {
                CargarImagenPC("Piedra");
            }
            else
            {
                if (NUM >= 40 && NUM <= 60)
                {
                    CargarImagenPC("Papel");
                }
                else
                {
                    CargarImagenPC("Tigera");
                }
            }
            if (Usuario.Equals(pc))
            {
                textBoxPantalla.Text = "Empate, ambos elegieron: " + Usuario;
            }
            else
            {
                if (Usuario.Equals("Piedra") && pc.Equals("Papel"))
                {
                    textBoxPantalla.Text = "Gana PC con: " + pc;
                }
                else
                {
                    if (Usuario.Equals("Piedra") && pc.Equals("Tigera"))
                    {
                        textBoxPantalla.Text = "Gana Usuario con: " + Usuario;
                    }
                    else
                    {
                        if (Usuario.Equals("Papel") && pc.Equals("Piedra"))
                        {
                            textBoxPantalla.Text = "Gana Usuario con: " + Usuario;
                        }
                        else
                        {
                            if (Usuario.Equals("Papel") && pc.Equals("Tigera"))
                            {
                                textBoxPantalla.Text = "Gana PC con: " + pc;
                            }
                            else
                            {
                                if (Usuario.Equals("Tigera") && pc.Equals("Piedra"))
                                {
                                    textBoxPantalla.Text = "Gana PC con: " + pc;
                                }
                                else
                                {
                                    textBoxPantalla.Text = "Gana Usuario con: " + Usuario;
                                }
                            }
                        }
                    }
                }
            }

        }
    }
}
