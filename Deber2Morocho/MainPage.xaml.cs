using System;
using Xamarin.Forms;

namespace Deber2Morocho
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {


                ///Primer Parcial
                double dato1 = Convert.ToDouble(txtNotaS1.Text) * (0.3);
                double dato2 = Convert.ToDouble(txtExamen1.Text) * (0.2);

                double notaParcial1 = dato1 + dato2;

                txtNotaParcial1.Text = notaParcial1.ToString();

                ///Segundo Parcial
                double dato3 = Convert.ToDouble(txtNotaS2.Text) * (0.3);
                double dato4 = Convert.ToDouble(txtExamen2.Text) * (0.2);
                double notaParcial2 = dato3 + dato4;

                txtNotaParcial2.Text = notaParcial2.ToString();

                ///Nota Final y Estado
                double notafinal = notaParcial1 + notaParcial2;
                txtNotaFinal.Text = notafinal.ToString();

                if (notafinal >= 7)
                {
                    txtEstado.Text = "Aprobado";
                    DisplayAlert("Felicitaciones!!", "Aprobado", "Cerrar");
                }
                if (notafinal >= 5 && notafinal <= 6.9)
                {
                    txtEstado.Text = "Complmentario";
                    DisplayAlert("No cumples con los requisitos para aprobar: ", "Reprobado", "CERRAR");
                }
                else
                {
                    txtEstado.Text = "Reprobado";
                    DisplayAlert("Suerte la proxima vez", "Reprobado", "Cerrar");
                }


            }
            catch (Exception ex)
            {
                DisplayAlert("Alerta", ex.Message, "Cerrar");


            }

        }
    }
}
