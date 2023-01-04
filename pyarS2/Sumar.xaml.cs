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
    public partial class Sumar : ContentPage
    {
        public Sumar()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double dato1 = Convert.ToDouble(txtDatoUno.Text);
            double dato2 = Convert.ToDouble(txtDatoDos.Text);
            double dato3 = Convert.ToDouble(txtDatoTres.Text);

            double resultado = dato1 + dato2 + dato3;
            txtResultado.Text = resultado.ToString();
        }
    }
}