using System;
using System.Deployment.Application;
using System.Drawing;
using System.Windows.Forms;
using Arkanoid.Core.Controller;
using Arkanoid.Core.Gameplay;

namespace Arkanoid
{
  public partial class Player : UserControl
  {
    //Se crean e inicializan las variables que contienen las imagenes del diseño
    private Form frm;
    private const string path = "../../Resources/";
    private Image title = new Bitmap(path+"nickname.png");
    private Image continuar = new Bitmap(path+"btn_continuar.png");
    private Image continuarh = new Bitmap(path+"btn_continuar_hover.png");
    
    public Player(Form frm)
    {
      this.frm = frm;
      InitializeComponent();
      //Se muestran las imagenes del titulo y el boton "Continuar"
      ptb_title.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_title.Image = title;
      ptb_continuar.SizeMode = PictureBoxSizeMode.StretchImage;
      ptb_continuar.Image = continuar;
    }

    private void ptb_continuar_Click(object sender, EventArgs e)
    {
      try
      {
        //Se valida que el nickname no se encuentre vacio
        if (!txt_nickname.Text.Equals(""))
        {
          if (txt_nickname.Text.Trim().Length < 50)
          {
            if (Convert.ToInt32(n_vidas.Text) > 0)
            {
              if (Convert.ToInt32(n_vidas.Text) < 11)
              {

                //Se guarda el valor indicado de vidas que se eligieron en las variables
                Settings.Hearts = Convert.ToInt32(n_vidas.Text);
                Settings.HeartsTotal = Convert.ToInt32(n_vidas.Text);
                //Se muestra la pantalla de juego y se esconde la de jugador
                var game = new Game(txt_nickname.Text);
                game.Show();
                frm.Hide();
              }
              else
              {
                throw new ExceededMaxLifesException("Ha introducido mas de 10 vidas");
              }
            }
            else
            {
              throw new LessThanOneValueException("Debe introducir una cantidad de vidas mayor a cero");
            }
          }
          else
          {
            throw new ExceededMaxCharactersException("Ha introducido mas de 50 caracteres permitidos");
          }
        }
        else
        {
          throw new EmptyNicknameException("Debe ingresar el Nickname");
        }
      }
      catch (EmptyNicknameException ex)
      {
        MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (ExceededMaxCharactersException ex)
      {
        MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (LessThanOneValueException ex)
      {
        MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
      catch (ExceededMaxLifesException ex)
      {
        MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void ptb_continuar_MouseEnter(object sender, EventArgs e)
    {
      //Cambia la imagen del boton "Continuar" cuando el puntero se situa sobre el
      ptb_continuar.Image = continuarh;
      ptb_continuar.SizeMode = PictureBoxSizeMode.StretchImage;
    }

    private void ptb_continuar_MouseLeave(object sender, EventArgs e)
    {
      //Cambia la imagen del boton "Continuar" cuando el puntero deja de estar sobre el
      ptb_continuar.Image = continuar;
      ptb_continuar.SizeMode = PictureBoxSizeMode.StretchImage;
    }
  }
}