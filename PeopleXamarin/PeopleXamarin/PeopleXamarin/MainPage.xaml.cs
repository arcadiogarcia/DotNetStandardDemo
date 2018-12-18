using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PeopleXamarin
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PeopleList.ItemsSource = PeopleLibrary.People.GetPeople();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            PeopleLibrary.People.AddPerson(new PeopleLibrary.Person
            {
                FirstName = "Xamarin",
                LastName = "User",
                PictureURI = "http://4.bp.blogspot.com/-p37377LziFs/U5nlmMJGteI/AAAAAAAACio/YynpmlGhXFc/s1600/tumblr_inline_mxaqdhiz3J1qzumo9.png"
            });
            PeopleList.ItemsSource = null;
            PeopleList.ItemsSource = PeopleLibrary.People.GetPeople();
        }
    }
}
