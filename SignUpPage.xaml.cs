namespace MauiAppHealth;

public partial class SignUpPage : ContentPage
{
	public SignUpPage()
	{
		InitializeComponent();
	}

    private  void ImageButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new OTPPage());
    }

    private void Entry_Completed(object sender, EventArgs e)
    {
        Navigation.PushAsync(new OTPPage());
    }
}