using Microsoft.Maui.Controls;

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
        LabelNome.Text = Atual.GetPersonagemNome();
    
        Atual.Setsedelvl(0.5);
        Atual.Setfomelvl(0.5);
        Atual.Settristelvl(0.5);
    
    }
     void TempoPassado()
     {
         if(Atual.Morte())
         {
            FrameBarra.IsVisible = false;
            FrameObjetos.IsVisible = false;

         }
        else 
        {
         FrameBarra.IsVisible = true;
         FrameObjetos.IsVisible = true;
        
        }
         Atual.Setfomelvl(Atual.Getfomelvl() - 0.1);
         BarraHormonio.Progress = Atual.Getfomelvl();

         Atual.Setsedelvl(Atual.Getsedelvl() - 0.01);
         BarraBomba.Progress = Atual.Getsedelvl();

         Atual.Settristelvl(Atual.Gettristelvl() - 0.1);
         BarraCalvicie.Progress = Atual.Gettristelvl();

         Personagem1.Setfomelvl(Personagem1.Getfomelvl() - 0.01);
         Personagem1.Setsedelvl(Personagem1.Getsedelvl() - 0.0001);
         Personagem1.Settristelvl(Personagem1.Gettristelvl() - 0.00001);      

         Personagem2.Setfomelvl(Personagem2.Getfomelvl() - 0.01);
         Personagem2.Setsedelvl(Personagem2.Getsedelvl() - 0.0001);
         Personagem2.Settristelvl(Personagem2.Gettristelvl() - 0.00001);      

        Personagem3.Setfomelvl(Personagem3.Getfomelvl() - 0.01);
         Personagem3.Setsedelvl(Personagem3.Getsedelvl() - 0.0001);
         Personagem3.Settristelvl(Personagem3.Gettristelvl() - 0.00001);      





     }
    private void ClicouHalterDireito(Object sender, EventArgs args)
    {
        if (Atual == Personagem1)
            Atual = Personagem2;
        else if (Atual == Personagem2)
            Atual = Personagem3;
        else if (Atual == Personagem3)
                 Atual = Personagem1;
        
        ImagemPet.Source = Atual.GetArquivo();
        LabelNome.Text = Atual.GetPersonagemNome();
        BarraHormonio.Progress = Atual.Getfomelvl();
        BarraBomba.Progress = Atual.Getsedelvl();
        BarraCalvicie.Progress = Atual.Gettristelvl();
    
    
    
    }
        
}