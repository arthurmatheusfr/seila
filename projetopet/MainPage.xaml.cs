namespace projetopet;

public partial class MainPage : ContentPage
{
     Capivara Personagem1;
     Jacare Personagem2;
     Flamengo Personagem3;
     Personagem Atual;
    public MainPage()
    {
        InitializeComponent();
        
        Personagem1 = new Capivara();
        Personagem2 = new Jacare();
        Personagem3 = new Flamengo();
        Atual = Personagem1;
        ImagemPet.Source = Atual.GetArquivo();
    }

    void QuandoClicarnoBotao(Object sender, EventArgs args)
    {
        if (Atual == Personagem1)
            Atual = Personagem2;
        else if (Atual == Personagem2)
            Atual = Personagem1;
        
        ImagemPet.Source = Atual.GetArquivo();
    }
}