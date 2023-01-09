namespace MauiAppHealth;

public partial class OTPPage : ContentPage
{
	public OTPPage()
	{
		InitializeComponent();
	}

    private void Entry_Completed(object sender, EventArgs e)
    {
		var otp = txtO.Text+""+ txtT.Text + "" + txtP.Text;
		if (otp == "111")
			 Navigation.PushAsync(new SetUpProfilePage());

    }
}