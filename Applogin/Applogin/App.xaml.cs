using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Applogin
{
    public partial class App : Application
    {
        public List<DadosUsuarios> list_usuarios = new List<DadosUsuarios>
        {
            new DadosUsuario()
            {

                Email = "Isa@Etec",
                Nome  = "Aluno",
                Senha = "876",


            },
            new DadosUsuario()
        }   { 
                Email = "belinha@Etec",
                Nome  = "Aluno",
                Senha = "932"
            }

        };
          
        public App()
{
    InitializeComponent();

    if (Properties.ContainsKey("usuario_logado"))
        MainPage = new Protegida();
    else
        MainPage = new Login();
}