using MauiApp1.Services;
using MauiApp1.ViewModels;
using MauiApp1.Views;


namespace MauiApp1;
public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
        
        //Services
        builder.Services.AddSingleton<IItemService, ItemService>();

		//Views Registration
		builder.Services.AddSingleton<UserItemListPage>();
        builder.Services.AddSingleton<AddUpdateUserItemDetail>();

        //View Models
        builder.Services.AddSingleton<UserListPage>();
        builder.Services.AddSingleton<AddUpdateUserItem>();

        return builder.Build();
	}
}
