using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cbanchi_BioApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Skills : ContentPage
        
	{
     public ObservableCollection<string> SkillsPage { get; set; }
    public Skills ()
		{
			InitializeComponent ();

            SkillsPage = new ObservableCollection<string>();
            SkillsPage.Add("C++");
            SkillsPage.Add("Visual Basic");
            SkillsPage.Add("Talking");
            SkillsPage.Add("Pro Builder; Fortnite");
            SkillsPage.Add("Good at Fixing Computer Problems for Elder People");
           
        }
	}
}