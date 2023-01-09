namespace MauiAppHealth;

public partial class BicepsPage : ContentPage
{
	public BicepsPage()
	{
		InitializeComponent();
        var list = new List<string>
            {
                "video_thumb.png",
                "video_thumb.png",
                "video_thumb.png"
            };
        TheCarousel.ItemsSource = list;
    }
}