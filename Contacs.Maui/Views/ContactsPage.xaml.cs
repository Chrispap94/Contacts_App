using Contacs.Maui.Models;
using System.Xml.Linq;

namespace Contacs.Maui.Views;

public partial class ContactsPage : ContentPage
{
	public ContactsPage()
	{
		InitializeComponent();
		List<Models.Contact> contacts = ContactRepository.GetContacts();
		ListContacts.ItemsSource = contacts;
	}
	 
    private async void ListContacts_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
		if(ListContacts.SelectedItem != null)
		{
			await Shell.Current.GoToAsync($"{nameof(EditContactPage)}?id={((Models.Contact)ListContacts.SelectedItem).ContactID}"); // ean exi epilegi perase to sigekrimeno 
		}

    }

    private void ListContacts_ItemTapped(object sender, ItemTappedEventArgs e)
    {
		ListContacts.SelectedItem = null;
    }
}