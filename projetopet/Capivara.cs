namespace projetopet;

public class Capivara : Personagem;

public Capivara() : base()
  {
    Setfomelvl(0.9);
    Setsedelvl(0.6);
  }
  public override string GetImageName()
  {
    return "capivara.webp";
  }

 public override void Comer()
  {
    var currentfomelvl = Getfomelvl();
    Setfomelvl(currentfomelvl + .3);
  }

public override void Beber()
  {
    var currentsedelvl = Getsedelvl();
    Setsedelvl(currentsedelvl + .4);
  }
public override void Brincar()
  {
    var currenttristelvl = Gettristelvl();
    Settristelvl(currenttristelvl + .4);
  }
  public override void TempoPassado()
  {
    var currenttristelvl = Gettristelvl();
    Settristelvl(currenttristelvl - .04);

    var currentsedelvl = Getsedelvl();
    Setsedelvl(currentsedelvl - .005);

    var currentfomelvl = Getfomelvl();
    Setfomelvl(currentfomelvl - .02);
  }