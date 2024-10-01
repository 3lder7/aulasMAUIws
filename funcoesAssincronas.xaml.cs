namespace aulasMAUI
{
    public partial class funcAssync : ContentPage
    {
        string nome;

        public funcAssync()
        {
            InitializeComponent();
        }

        private async void btnClick_Clicked(object sender, EventArgs e) // pelo fato de ser uma fun��o assincrona, � necess�rio um m�todo assincrono
        {
            nome = await DisplayPromptAsync("Nome", "Digite seu nome:", "OK"); //display == abrir na tela, prompt = texto, async = assincrono
            await DisplayAlert("Aviso", "Ol� " + nome, "Ok");
        }
    }

}