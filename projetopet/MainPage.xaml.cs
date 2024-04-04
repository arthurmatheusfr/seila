namespace projetopet;

public partial class MainPage : ContentPage
{
    private Capivara Personagem1;
    private Jacare Personagem2;
    private Gaivota Personagem3;
    private Personagem Atual;
    public MainPage()
    {
        InitializeComponent();
        
        Personagem1 = new Capivara();
        Personagem2 = new Jacare();
        Personagem3 = new Gaivota();
        Atual = Personagem1;
        personagemimagem.Source = Atual.GetImageName();
    }

    void QuandoClicarnoBotao(Object sender, EventArgs args)
    {
        if (Atual == Personagem1)
            Atual = Personagem2;
        else if (Atual == Personagem2)
            Atual = Personagem1;
        
        personagemimagem.Source = Atual.GetImageName();
    }
}