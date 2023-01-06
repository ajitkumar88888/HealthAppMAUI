namespace MauiAppHealth;

public partial class SetUpProfile2Page : ContentPage
{
	public SetUpProfile2Page(string username)
	{
		InitializeComponent();

        if(!string.IsNullOrEmpty(username))
        txtusername.Text = "hello "+username;
        else
        txtusername.Text = "hello user";

    }
}