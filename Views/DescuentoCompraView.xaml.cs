using ExamenMvvm.ViewModels;

namespace ExamenMvvm.Views;

public partial class DescuentoCompraView : ContentPage
{
	private DescuentoCompraViewModel ViewModel;


	public DescuentoCompraView()
	{
		InitializeComponent();
		ViewModel = new DescuentoCompraViewModel();
		BindingContext = ViewModel;


	}
}