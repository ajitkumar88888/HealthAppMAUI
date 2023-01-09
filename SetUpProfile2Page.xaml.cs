namespace MauiAppHealth;

public partial class SetUpProfile2Page : ContentPage
{

    public string Username = string.Empty;
	public SetUpProfile2Page(string username)
	{
		InitializeComponent();

        if(!string.IsNullOrEmpty(username))
        txtusername.Text = "hello "+username;
        else
        txtusername.Text = "hello user";

        Username = username;
    }

    private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new SetUpProfile3Page(Username));
    }

    private void TapGestureRecognizer_Tapped_1(object sender, TappedEventArgs e)
    {
        Navigation.PushAsync(new SetUpProfile3Page(Username));
    }
}