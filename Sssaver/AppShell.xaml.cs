using System;
using System.Collections.Generic;
using Sssaver.ViewModels;
using Sssaver.Views;
using Xamarin.Forms;

namespace Sssaver
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
