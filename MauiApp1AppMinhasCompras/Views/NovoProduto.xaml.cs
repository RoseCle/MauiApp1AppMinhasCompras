using MauiApp1AppMinhasCompras.Models;

namespace MauiApp1AppMinhasCompras.Views;

public partial class NovoProduto : ContentPage
{    
    public NovoProduto()
    {
        InitializeComponent();       
    }

    private async void ToolbarItem_click(object sender, EventArgs e)
    {
        try
        {
            Produto p = new Produto
            {
                Descricao = txt_descricao.Text,
                Quantidade = Convert.ToDouble(txt_quantidade.Text),
                Preco = Convert.ToDouble(txt_preco.Text),
            };

            await App.Db.Insert(p);

            await DisplayAlert("Sucesso", "Produto inserido com sucesso", "OK");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Ops", ex.Message, "OK");
        }
    }
}
