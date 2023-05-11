using MauiApp1.ViewModels;
using MauiApp1.Models;

namespace MauiApp1.Views;

public partial class ItemListView : ContentPage
{
    public ItemListView()
	{
		InitializeComponent();
        this.BindingContext = new ItemListViewModel();
}
}