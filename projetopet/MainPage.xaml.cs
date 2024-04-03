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
   if (atual==Personagem1)
      atual = Personagem2;
    else if(atual==Personagem2)
    atual = Personagem1;
    personagemimagem.Source=atual.GetImageName();
  }
	
}

