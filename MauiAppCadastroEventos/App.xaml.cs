using Microsoft.Extensions.DependencyInjection;
using MauiAppCadastroEventos.Models;

namespace MauiAppCadastroEventos
{
    public partial class App : Application
    {
        public List<Locais> lista_Locais = new List<Locais>{

        new Locais()
        {
            Local = "Sítio",
            preco = 70.00
        },
        new Locais()
        {
            Local = "Chácara",
            preco = 120.00
        },
        new Locais()
        {
            Local = "Salão de Festas",
            preco = 200.00
        } 
        };
        
            
            
         public App()
        {
            InitializeComponent();
        
            MainPage = new NavigationPage(new Views.Cadastro());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);

            window.Width = 600;
            window.Height = 600;
            return window;
        }
    }
}