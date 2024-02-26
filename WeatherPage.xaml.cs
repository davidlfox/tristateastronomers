namespace Tristate;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
	}

    private void playWeatherAnimation_Clicked(object sender, EventArgs e)
    {
		imgWeatherAnimation.IsAnimationPlaying = true;
    }

    private void stopWeatherAnimation_Clicked(object sender, EventArgs e)
    {
        imgWeatherAnimation.IsAnimationPlaying = false;
    }
}