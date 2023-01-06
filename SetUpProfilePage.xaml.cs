namespace MauiAppHealth;

public partial class SetUpProfilePage : ContentPage
{
	public SetUpProfilePage()
	{
		InitializeComponent();
	}

    private async void Entry_Completed(object sender, EventArgs e)
    {
		
		await Navigation.PushModalAsync(new SetUpProfile2Page(txtusername.Text));
    }
}