namespace Tristate;

public partial class SocialPage : ContentPage
{
    readonly string xDeepUrl = "twitter://user?screen_name=TSAstronomers";
    readonly string xWebUrl = "https://twitter.com/TSAstronomers";

    public SocialPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

	public async void OpenXTapped(object sender, TappedEventArgs args)
	{
        try
        {
            // Attempt to open in the app
            bool canOpen = await Launcher.TryOpenAsync(xDeepUrl);

            // If unable to open in the app, fallback to the web URL
            if (!canOpen)
            {
                await Launcher.OpenAsync(xWebUrl);
            }
        }
        catch (Exception ex)
        {
            // Log error or handle exception
            // Fallback to web if there's an exception
            await Launcher.OpenAsync(xWebUrl);
        }
    }
}