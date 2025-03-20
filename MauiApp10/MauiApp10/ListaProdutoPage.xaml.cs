namespace MauiApp10;

public partial class ListaProdutoPage : ContentPage
{
	public ListaProdutoPage()
	{
        List<Produto> lista = Produto.Lista;

		lstProduto.BindingContext = lista;

        InitializeComponent();
	}
}