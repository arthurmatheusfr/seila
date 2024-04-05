namespace projetopet;


public class Personagem
{
 double fomelvl;
 double sedelvl;
 double tristelvl;
protected string PersonagemImagem;
public Personagem()
  {
    fomelvl  = 0;
    sedelvl = 0;
    tristelvl = 0;
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

public string GetArquivo()
 
 {
    return PersonagemImagem;
  }
}