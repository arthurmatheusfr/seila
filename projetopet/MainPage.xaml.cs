namespace projetopet;

public partial class MainPage : ContentPage
{
   
	public MainPage()
	{
		InitializeComponent();
  var Personagem1 = new Capivara();
  var Personagem2 = new Jacare();
  var Personagem3 = new Gaivota();
	personagemimagem.Source=atual.GetImageName();
  }
  void QuandoClicarnoBotao(Object Sender, EventArgs args)
  {
   if (Atual==Personagem1)
      Atual = Personagem2;
    else if(Atual==Personagem2)
    Atual = Personagem1;
    personagemimagem.Source=Atual.GetImageName();
  }
	
}

