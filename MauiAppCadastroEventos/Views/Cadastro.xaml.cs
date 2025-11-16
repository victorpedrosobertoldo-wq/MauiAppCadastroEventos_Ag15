using MauiAppCadastroEventos.Models;

namespace MauiAppCadastroEventos.Views;

public partial class Cadastro : ContentPage
{
    App Propriedades;
    public Cadastro()
	{
		InitializeComponent();
	
        Propriedades = (App)Application.Current;
        pkr_Local.ItemsSource = Propriedades.lista_Locais;

        dt_pkr_inicio.MinimumDate = DateTime.Today;
        dt_pkr_inicio.MaximumDate = DateTime.Today.AddMonths(1);

        AtualizarDatasFinais();

        dt_pkr_inicio.DateSelected += (s, e) => AtualizarDatasFinais();
    }

    private void AtualizarDatasFinais()
    {
        var inicio = dt_pkr_inicio.Date;

        
        var minimoFinal = inicio + TimeSpan.FromDays(1);

        dt_pkr_final.MinimumDate = minimoFinal;
        dt_pkr_final.MaximumDate = DateTime.Today.AddMonths(3);

        dt_pkr_final.Date = minimoFinal;

        
        dt_pkr_final.MaximumDate = dt_pkr_final.MaximumDate;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            ResumoCadastro R = new ResumoCadastro
            {
                Nome = nome_evento.Text,
                Localselecionado = (Locais)pkr_Local.SelectedItem,
                QtdPessoas = Convert.ToInt32(stp_pessoas.Value),
                DataInicial = (DateTime)dt_pkr_inicio.Date,
                DataFinal = (DateTime)dt_pkr_final.Date,
            };

            await Navigation.PushAsync(new Views.Resultado()
            {
                BindingContext = R,
            });
        }
        catch (Exception ex)
        {
            await DisplayAlert("erro", ex.Message, "ok");
        }
    }
}