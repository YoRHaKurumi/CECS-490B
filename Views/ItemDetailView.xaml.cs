using MauiApp1.ViewModels;

namespace MauiApp1.Views;

public partial class ItemDetailView : ContentPage
{
	public ItemDetailView()
	{
		InitializeComponent();
		this.BindingContext = new ItemDetailViewModel();
	}
}