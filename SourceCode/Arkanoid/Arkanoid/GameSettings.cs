using System;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Core.Gameplay;

namespace Arkanoid
{
    public partial class GameSettings : Form
    {
        public GameSettings(bool PrimeInicio)
        {
            InitializeComponent();
            cbMouse.Checked = Settings.MousePlay1;
            if (PrimeInicio)
            {
                Aceptar.Text = "Iniciar juego";
               
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            //Se cambia el valor de la variable playing a "true" para indicar que esta activo el juego
            Settings.Playing = true;
            this.Close();
        }

        private void cbMouse_CheckedChanged(object sender, EventArgs e)
        {
            Settings.MousePlay1 = cbMouse.Checked;
        }
    }
}