namespace projetopet;


public class Personagem
{
 double fomelvl;
 double sedelvl;
 double tristelvl;
protected string PersonagemImagem;
protected string GameOver;
protected string PersonagemNome;
bool AnimalMorto;
public Personagem()
  {
    fomelvl  = 0;
    sedelvl = 0;
    tristelvl = 0;
  }
 
 public void Setfomelvl(double h)
  {
   if(h < 0)
   fomelvl = 0;
   else if (h > 1)
   fomelvl = 1;
   else
   fomelvl = h;
  }
public double Getfomelvl()
  {
    return fomelvl;
  }
  
   protected void Setsedelvl(double t)
  {
     if(t < 0)
   sedelvl = 0;
   else if (t > 1)
   sedelvl = 1;
   else
   sedelvl = t;
  }

 public double Getsedelvl()
  {
    return sedelvl;
  }
protected void Settristelvl(double s)
  {
     if(s < 0)
   sedelvl = 0;
   else if (s > 1)
   sedelvl = 1;
   else
   sedelvl = s;
  }
 

  public double Gettristelvl()
  {
    return tristelvl;
  }

public string GetArquivo()
 
 {
  if(AnimalMorto == true)
      return GameOver;
      else
    return PersonagemImagem;
  }

  public string GetPersonagemNome()
  {
    return PersonagemNome;
  }
}