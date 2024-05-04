namespace Contacs.Maui.Views;

public partial class AddContactPage : ContentPage
{
	public AddContactPage()
	{
		InitializeComponent();
	}

    private void Cancel_btn_Clicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(".."); //piso 
    }
}