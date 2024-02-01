using System.Windows.Input;

namespace Tristate;

public partial class MotdPage : ContentPage
{
    // Launcher.OpenAsync is provided by Essentials.
    public ICommand TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

    public MotdPage()
	{
		InitializeComponent();
        BindingContext = this;
	}
}