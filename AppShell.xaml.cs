using MauiApp1.Views;

namespace MauiApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(ItemDetailView), typeof(ItemDetailView));
        Routing.RegisterRoute(nameof(AddUpdateUserItemDetail), typeof(AddUpdateUserItemDetail));
    }
}
