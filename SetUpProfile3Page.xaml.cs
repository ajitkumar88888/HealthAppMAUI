namespace MauiAppHealth;

public partial class SetUpProfile3Page : ContentPage
{
    int height;
    int weight;
    public SetUpProfile3Page(string username)
	{
		InitializeComponent();
        if (!string.IsNullOrEmpty(username))
            txtusername.Text = "hello " + username;
        else
            txtusername.Text = "hello user";
    }

    private void sldweight_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        weight = (int)sldweight.Value;
        lblweight.Text = $"{weight} kgs";
    }

    private void sldheight_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        height = (int)sldheight.Value;
        lblheight.Text = $"{height} cms";
    }
}