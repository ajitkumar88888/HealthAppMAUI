namespace MauiAppHealth;

public partial class SetUpProfilePage : ContentPage
{
	public SetUpProfilePage()
	{
		InitializeComponent();
	}

    private  void Entry_Completed(object sender, EventArgs e)
    {
		
	  Navigation.PushAsync(new SetUpProfile2Page(txtusername.Text));
    }
}