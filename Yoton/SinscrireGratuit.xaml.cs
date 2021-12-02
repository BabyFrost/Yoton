using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Yoton
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SinscrireGratuit : ContentPage
    {
        public SinscrireGratuit()
        {
            InitializeComponent();

        }

        async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Cette adresse est déjà connectée à un compte", "Souhaitez--vous plutôt vous connecter ?", "Oui", "Non");
            //Debug.Writeline("Answer: " + answer);
        }
    }
}

