using Tristate.Resources.Styles;

namespace Tristate;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    private void themeSwitch_Toggled(object sender, ToggledEventArgs e)
    {
        var theme = sender as Switch;
        if(theme.IsToggled)
        {
            toggle(new DarkTheme());
        }
        else
        {
            toggle(new LightTheme());
        }
    }

    private void toggle(ResourceDictionary theme)
    {
        ICollection<ResourceDictionary> mergedDictionaries = Application.Current.Resources.MergedDictionaries;
        if (mergedDictionaries != null)
        {
            mergedDictionaries.Clear();
            mergedDictionaries.Add(theme);
        }
    }
}