using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace pyarS2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Notas : ContentPage
    {
        public Notas(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            double notaSeguimiento1 = Convert.ToDouble(txtNotaSeguimiento1.Text) * 0.3;
            double notaExamen1 = Convert.ToDouble(txtNotaExamen1.Text) * 0.2;

            double notaSeguimiento2 = Convert.ToDouble(txtNotaSeguimiento2.Text) * 0.3;
            double notaExamen2 = Convert.ToDouble(txtNotaExamen2.Text) * 0.2;

            double notaParcial1 = notaSeguimiento1 + notaExamen1;
            double notaParcial2 = notaSeguimiento2 + notaExamen2;

            txtParcial1.Text = notaParcial1.ToString();
            txtParcial2.Text = notaParcial2.ToString();

            double notaFinal = notaParcial1 + notaParcial2;

            string mensaje;

            if (ValidarFormulario("Nota de seguimiento 1", txtNotaSeguimiento1.Text) &&
            ValidarFormulario("Nota de Examen 1", txtNotaExamen1.Text) &&
            ValidarFormulario("Nota de seguimiento 2", txtNotaSeguimiento2.Text) &&
            ValidarFormulario("Nota de Examen 2", txtNotaExamen2.Text))
            {
                if (notaFinal > 0.1 && notaFinal <= 4.9)
                {
                    mensaje = $"La nota final es: {notaFinal}, por lo tanto usted perdio el semestre";
                }
                else if (notaFinal > 4.9 && notaFinal <= 6.9)
                {
                    mensaje = $"La nota final es: {notaFinal}, por lo tanto usted tiene que rendir el examen complementario";
                }
                else
                {
                    mensaje = $"La nota final es: {notaFinal}, por lo tanto usted es aprobado";
                }
                DisplayAlert("Mensaje", mensaje, "Cerrar");
            }
        }

        private bool ValidarFormulario(string nombreCampo, string valor)
        {

            if (string.IsNullOrEmpty(valor))
            {
                DisplayAlert("Error", $"El campo {nombreCampo} es requerido", "Cerrar");
                return false;
            }
            //else if (valor.StartsWith(".") && valor.Length==1)
            //{
            //    DisplayAlert("Error", $"El campo {nombreCampo} debe comenzar con valores numéricos", "Cerrar");
            //    return;
            //}
            double numero;
            try
            {
                numero = Convert.ToDouble(valor);
            }
            catch (Exception)
            {
                return false;            
            }
            string mensaje;

            if (numero <= 0 || numero > 10)
            {
                mensaje = $"En el campo {nombreCampo} solo puede ingresar valores desde 0.1 hasta 10";
                DisplayAlert("Error", mensaje, "Cerrar");
                return false;
            }
            return true;
        }
    }
}