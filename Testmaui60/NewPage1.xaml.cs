using System.Diagnostics.Metrics;

namespace Testmaui60;

public partial class NewPage1 : ContentPage
{
    private int count;

	public NewPage1()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        count++;
        counterLbl.Text = $"Click Count: {count}";

        SemanticScreenReader.Announce(counterLbl.Text);
    }
}
