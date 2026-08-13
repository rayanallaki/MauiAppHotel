namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	App PropriedadesApp;
	public ContratacaoHospedagem()
	{
		InitializeComponent();

		PropriedadesApp = (App)Application.Current;

		pck_quarto.ItemsSource = PropriedadesApp.lista_quartos;
    }
	private void Button_Clicked(object sender, EventArgs e)
    {
		try 
		{
			Navigation.PushAsync(new HospedagemContratada());
		}
		catch(Exception ex) 
		{ 
			DisplayAlert("ERRO!", ex.Message, "OK");
        }
    }
}