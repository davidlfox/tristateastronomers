namespace Tristate;

public partial class SocialPage : ContentPage
{
	string xDeepUrl = "twitter://user?screen_name=TSAstronomers";
	string xWebUrl = "";

    public SocialPage()
	{
		InitializeComponent();
        BindingContext = this;
    }

	public async Task OpenXCommand()
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