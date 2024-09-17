using ExamenMvvm.ViewModels;

namespace ExamenMvvm.Views;

public partial class DescuentoCompra : ContentPage
{
	private DescuentoCompraViewModel ViewModel;


	public DescuentoCompra()
	{
		InitializeComponent();
		ViewModel = new DescuentoCompraViewModel();
		BindingContext = ViewModel;


	}
}