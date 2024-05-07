using Contacs.Maui.Models;

namespace Contacs.Maui.Views;

[QueryProperty(nameof(contactID),"id")] 
public partial class EditContactPage : ContentPage
{
	private Models.Contact contact;
	public EditContactPage()
	{
		InitializeComponent();
	}

    private void Cancel_btn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");// piso 
    }

	public string contactID 
	{
		set
		{
            contact = ContactRepository.GetContactById(int.Parse(value));
			if(contact != null) 
			{
                entryName.Text = contact.Name;
                entryEmail.Text = contact.Email;
                lblname.Text = contact.Name;
            }
            
		}
	}
	//test
    private void Update_btn_Clicked(object sender, EventArgs e)
    {
		contact.Name = entryName.Text;
		contact.Email = entryEmail.Text;
		ContactRepository.UpdateContact(contact.ContactID, contact);
        Shell.Current.GoToAsync("..");
    }
}