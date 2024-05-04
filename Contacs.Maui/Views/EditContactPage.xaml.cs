namespace Contacs.Maui.Views;

public partial class EditContactPage : ContentPage
{
	public EditContactPage()
	{
		InitializeComponent();
	}

    private void Cancel_btn_Clicked(object sender, EventArgs e)
    {
		Shell.Current.GoToAsync("..");// piso 
    }
}