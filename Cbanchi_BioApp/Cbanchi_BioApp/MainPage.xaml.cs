using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Cbanchi_BioApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void About_Me_Navigation_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AboutMe());
        }

        private void Skills_Navigation_Clicked(object sender, EventArgs e)
        {

        }

        private void Contact_Navigation_Clicked(object sender, EventArgs e)
        {

        }
    }
}
