using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cbanchi_BioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContactMe : ContentPage
	{
		public ContactMe ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameEntry.Text))
            {
                DisplayAlert("Error", "Enter your Name.", "OK!");
                return;
            }

            if (string.IsNullOrEmpty(emailEntry.Text))
            {
                DisplayAlert("Error", "Enter your Email.", "OK!");
            }

            if (string.IsNullOrEmpty(messageEditor.Text))
            {
                DisplayAlert("Error", "Enter your Message.", "OK!");
            }

            DisplayAlert("Alert", "Your Message Was Sent!", "OK!");
        }
    }
}