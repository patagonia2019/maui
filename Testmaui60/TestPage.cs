namespace Testmaui60;

public class TestPage : ContentPage
{
    int counter = 0;

    Label counterLbl;

    public TestPage()
	{
        var scrollView = new ScrollView();

        var stackLayout = new StackLayout();
        scrollView.Content = stackLayout;

        counterLbl = new Label
        {
            Text = "Count: 0",
            FontSize = 22,
            FontAttributes = FontAttributes.Bold,
            HorizontalOptions = LayoutOptions.Center,
        };
        stackLayout.Children.Add(counterLbl);

        var btnCounter = new Button
        {
            Text = "Click To Count",
            HorizontalOptions = LayoutOptions.Center,
        };
        stackLayout.Children.Add(btnCounter);
        btnCounter.Clicked += OnClickedEvent;

        this.Content = scrollView;
    }

    private void OnClickedEvent(object sender, EventArgs e)
    {
        counter++;
        counterLbl.Text = $"Click Count: {counter}";

        SemanticScreenReader.Announce(counterLbl.Text);
    }
}
