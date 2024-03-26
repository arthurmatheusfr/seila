namespace projetopet;

public partial class MainPage : ContentPage
{
   List<Personagem> PersonagemList = new List<Personagem>();
	Personagem CurrentPersonagem;
  int currentPersonagemIndex = 0;
	public MainPage()
	{
		InitializeComponent();
    
    PersonagemList.Add(new Capivara());
    PersonagemList.Add(new Gaivota());
    PersonagemList.Add(new Jacare());


	}

	
}

