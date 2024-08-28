namespace TubePlayer.Presentation;

public partial class MainPage : Page
{
    public MainPage()
    {
        this.DataContext<MainViewModel>((page, vm) => page
            .NavigationCacheMode(NavigationCacheMode.Required)
            .Background(Theme.Brushes.Background.Default)
            .Content(new Grid()
                .SafeArea(SafeArea.InsetMask.All)
                .RowDefinitions("Auto, *")
                .Children(
                    new TextBox()
                        .Text(x => x
                            .Binding(() => vm.SearchTerm)
                            .Mode(BindingMode.TwoWay)
                            .UpdateSourceTrigger(UpdateSourceTrigger.PropertyChanged))
                        .PlaceholderText("Search term"),
                    new ListView()
                        .Grid(row: 1)
                        .ItemsSource(() => vm.VideoSearchResults)
                        .ItemTemplate<YoutubeVideo>(ytv =>
                            new StackPanel()
                                .Children(
                                    new TextBlock()
                                        .FontWeight(FontWeights.Bold)
                                        .Text(() =>
                                            ytv.Details.Snippet?.ChannelTitle),
                                    new TextBlock()
                                        .Text(() =>
                                            ytv.Details.Snippet?.Title))))));
    }
}
