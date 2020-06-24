namespace Arkanoid.Core.Controller
{
  public class Player
  {
    //Declarando variables
    private Model.Player new_player;

    private int id_player;
    private string nickname;
    private int lifes;
    
    public Player()
    {
      //Se llama a la clase Player del modelo
      new_player = new Model.Player();
    }

    public int IdPlayer
    {
      get => id_player;
      set => id_player = value;
    }

    public string Nickname
    {
      get => nickname;
      set => nickname = value;
    }

    public int Lifes
    {
      get => lifes;
      set => lifes = value;
    }

    //Metodo para insertar un jugador utilizando el metodo creado en la clase player dentro del modelo
    public bool createPlayer()
    {
      new_player.Nickname = this.nickname;
      new_player.Lifes = this.lifes;
      if(new_player.insertPlayer())
      {
        id_player = new_player.IdPlayer;
        return true;
      }
      return false;
    }
    
    //Metodo para verificar si un usuario ya existe en la base
    public int verifyPlayer()
    {
      new_player.Nickname = this.nickname;
      var score = new_player.selectLastScore();
      this.id_player = new_player.IdPlayer;
      if (id_player != null)
      {
        this.id_player = new_player.IdPlayer;
      }
      return score;
    }
  }
}