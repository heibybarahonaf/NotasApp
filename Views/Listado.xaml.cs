using NotasApp.Models;
namespace NotasApp.Views;

public partial class Listado : ContentPage
{
    public Listado()
    {
        InitializeComponent();
    }
    //
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        viewListado.Header = "Actualizando lista...";
        viewListado.ItemsSource = await App.db.SelectAll();
        viewListado.Header = string.Empty;
    }
    //
    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
        Notas nota = args.SelectedItem as Notas;
        await Navigation.PushAsync(new Detalle(nota));
    }
}