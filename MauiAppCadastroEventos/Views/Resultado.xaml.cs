using System.Threading.Tasks;

namespace MauiAppCadastroEventos.Views;

public partial class Resultado : ContentPage
{
	public Resultado()
	{
		InitializeComponent();
	}

    private async void btn_voltar(object sender, EventArgs e)
    {
        try
        {
            // Volta para a página anterior em vez de empilhar nova instância
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            await DisplayAlert("erro", ex.Message, "ok");
        }

    }
}