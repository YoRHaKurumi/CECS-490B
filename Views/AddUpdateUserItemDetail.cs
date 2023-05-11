using MauiApp1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Views
{
    public partial class AddUpdateUserItemDetail : ContentPage
    {
        public AddUpdateUserItemDetail(AddUpdateUserItem viewModel)
        {
            InitializeComponent();
            this.BindingContext = viewModel;
        }
    }
}
