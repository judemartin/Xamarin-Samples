using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace EntryForm
{
    public partial class EntryFormPage : ContentPage
    {
        public EntryFormPage()
        {
            InitializeComponent();
        }

        private void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            PersonalInformation personalnformation = (PersonalInformation)TableView.BindingContext;
            summaryLabel.Text =
                $"{personalnformation.Name} is {personalnformation.Age} years old, and has an email address " +
                $"of {personalnformation.EmailAddress}, and a phone number of {personalnformation.PhoneNumber}, and is {(personalnformation.IsProgrammer ? "" : "not")}" +
                "a programmer.";
        }
    }
}
