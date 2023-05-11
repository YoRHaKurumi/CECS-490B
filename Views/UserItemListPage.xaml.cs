using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp1.ViewModels;
namespace MauiApp1.Views
{
    public partial class UserItemListPage : ContentPage
    {
        private UserListPage _viewMode;
        public UserItemListPage(UserListPage viewModel)
        {
            InitializeComponent();
            _viewMode = viewModel;
            this.BindingContext = viewModel;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewMode.GetItemListCommand.Execute(null);
        }
    }
}
