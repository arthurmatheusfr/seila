namespace projetopet;


public class Personagem
{
 double fomelvl;
 double sedelvl;
 double tristelvl;

public Personagem()
  {
    fomelvl  = 0;
    sedelvl = 0;
    tristelvl = 0;
  }
   public virtual string GetImageName()
 
 {
    return "";
  }
 protected void Setfomelvl(double level)
  {
    if (level >= 0 && level <= 1)
      fomelvl = level;
    else if (level < 0)
      fomelvl = 0;
    else
      fomelvl = 1;
  }
public double Getfomelvl()
  {
    return fomelvl;
  }
  
   protected void Setsedelvl(double level)
  {
    if (level >= 0 && level <= 1)
      sedelvl = level;
    else if (level < 0)
      sedelvl = 0;
    else
      sedelvl = 1;
  }

 public double Getsedelvl()
  {
    return sedelvl;
  }
protected void Settristelvl(double level)
  {
    if (level >= 0 && level <= 1)
      tristelvl = level;
    else if (level < 0)
      tristelvl = 0;
    else
      tristelvl = 1;
  }
 

  public double Gettristelvl()
  {
    return tristelvl;
  }

  public virtual void Comer()
  {
    var currentfomelvl = Getfomelvl();
    Setfomelvl(currentfomelvl + 0.1);
  }
public virtual void Beber()
  {
    var currentsedelvl = Getsedelvl();
    Setsedelvl(currentsedelvl + 0.1);
  }
   public virtual void Brincar()
  {
    var currenttristelvl = Gettristelvl();
    Settristelvl(currenttristelvl + 0.1);
  }
public virtual void TempoPassado()
  {
    var currenttristelvl = Gettristelvl();
    Settristelvl(currenttristelvl - .01);

    var currentsedelvl = Getsedelvl();
    Setsedelvl(currentsedelvl - .01);

    var currentfomelvl = Getfomelvl();
    Setfomelvl(currentfomelvl - .01);
}
}