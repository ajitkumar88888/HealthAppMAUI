namespace MauiAppHealth;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new OTPPage());
    }

    private async void Entry_Completed(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new OTPPage());
    }
}