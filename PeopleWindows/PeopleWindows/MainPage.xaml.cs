using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PeopleWindows
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            PeopleList.ItemsSource = PeopleLibrary.People.GetPeople();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PeopleLibrary.People.AddPerson(new PeopleLibrary.Person
            {
                FirstName = "Windows",
                LastName = "User",
                PictureURI = "http://www.contegix.com/wp-content/uploads/2015/09/Windows_10_logo.png"
            });
            PeopleList.ItemsSource = null;
            PeopleList.ItemsSource = PeopleLibrary.People.GetPeople();
        }
    }
}
