namespace AulaMaui;

public partial class MainPage : TabbedPage
{
	private string? nome;
	public MainPage()
	{
		InitializeComponent();
	}

	private async void Bnt_clicked(Object sender, EventArgs e)
	{
		nome = await DisplayPromptAsync("Nome", "Digite seu nome", "ok");
		await DisplayAlert("Olá", nome, "ok");
	}
	
}
