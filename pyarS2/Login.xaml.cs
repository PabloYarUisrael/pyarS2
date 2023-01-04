using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pyarS2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2022";
            string clave = "uisrael2022";

            if (usuario == txtUsuario.Text && clave == txtClave.Text)
            {
                Navigation.PushAsync(new Notas(txtUsuario.Text));
            }
            else
            {
                DisplayAlert("ALERTA", "Usuario o clave incorrecta", "Cerrar");
            }
        }
    }
}