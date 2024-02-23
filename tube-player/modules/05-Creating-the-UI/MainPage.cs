using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Media.Imaging;
using Microsoft.UI.Xaml.Navigation;
using System;
using Uno.Extensions.Markup;
using Uno.Extensions.Navigation.UI;
using Uno.Material;
using Uno.Toolkit.UI;

namespace TubePlayer.Presentation;

public partial class MainPage : Page
{
    public MainPage()
    {
        this.DataContext<BindableMainModel>((page, vm) => page
            .Background(Theme.Brushes.Background.Default)
            .NavigationCacheMode(NavigationCacheMode.Required)
            .StatusBar
            (
                s => s
                    .Foreground(StatusBarForegroundTheme.Auto)
                    .Background(Theme.Brushes.Surface.Default)
            )
            .Resources
            (
                r => r
                    .Add("Icon_Chevron_Right", "F1 M 1.4099998474121094 0 L 0 1.4099998474121094 L 4.579999923706055 6 L 0 10.59000015258789 L 1.4099998474121094 12 L 7.409999847412109 6 L 1.4099998474121094 0 Z")
                    .Add("Icon_Search", "F1 M 12.5 11 L 11.710000038146973 11 L 11.430000305175781 10.729999542236328 C 12.410000324249268 9.589999556541443 13 8.110000014305115 13 6.5 C 13 2.9100000858306885 10.089999914169312 0 6.5 0 C 2.9100000858306885 0 0 2.9100000858306885 0 6.5 C 0 10.089999914169312 2.9100000858306885 13 6.5 13 C 8.110000014305115 13 9.589999556541443 12.410000324249268 10.729999542236328 11.430000305175781 L 11 11.710000038146973 L 11 12.5 L 16 17.489999771118164 L 17.489999771118164 16 L 12.5 11 L 12.5 11 Z M 6.5 11 C 4.009999990463257 11 2 8.990000009536743 2 6.5 C 2 4.009999990463257 4.009999990463257 2 6.5 2 C 8.990000009536743 2 11 4.009999990463257 11 6.5 C 11 8.990000009536743 8.990000009536743 11 6.5 11 Z")
            )
            .Content
            (
                new AutoLayout()
                    .PrimaryAxisAlignment(AutoLayoutAlignment.Center)
                    .VerticalAlignment(VerticalAlignment.Stretch)
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Width(400)
                    .Children
                    (
                        new NavigationBar()
                            .Width(400)
                            .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                            .Content
                            (
                                new AutoLayout()
                                    .PrimaryAxisAlignment(AutoLayoutAlignment.Center)
                                    .Orientation(Orientation.Horizontal)
                                    .Children
                                    (
                                        new Image()
                                            .Source(new BitmapImage(new Uri("https://picsum.photos/384/40")))
                                            .Stretch(Stretch.UniformToFill)
                                            .AutoLayout(primaryAlignment: AutoLayoutPrimaryAlignment.Stretch)
                                    )
                            ),
                        new AutoLayout()
                            .Background(Theme.Brushes.Surface.Default)
                            .Padding(12)
                            .Children
                            (
                                new TextBox()
                                    .Background(Theme.Brushes.Surface.Variant.Default)
                                    .Text(b => b.Binding(() => vm.SearchTerm).TwoWay().UpdateSourceTrigger(UpdateSourceTrigger.PropertyChanged))
                                    .Height(40)
                                    .PlaceholderText("Search")
                                    .CornerRadius(20)
                                    .BorderThickness(0)
                                    .Style(Theme.TextBox.Styles.Outlined)
                                    .ControlExtensions
                                    (
                                        icon:
                                            new PathIcon()
                                                .Data(StaticResource.Get<Geometry>("Icon_Search"))
                                                .Foreground(Theme.Brushes.OnSurface.Variant.Default)
                                    )
                            ),
                        new ListView()
                            .Background(Theme.Brushes.Background.Default)
                            .ItemsSource(() => vm.VideoSearchResults)
                            .Padding(12, 8)
                            .Navigation(request: "VideoDetails")
                            .AutoLayout(primaryAlignment: AutoLayoutPrimaryAlignment.Stretch)
                            .ItemTemplate<YoutubeVideo>
                            (
                                youtubeVideo =>
                                    new CardContentControl()
                                        .Margin(0, 0, 0, 8)
                                        .Style(StaticResource.Get<Style>("ElevatedCardContentControlStyle"))
                                        .Content
                                        (
                                            new AutoLayout()
                                                .Background(Theme.Brushes.Surface.Default)
                                                .CornerRadius(12)
                                                .PrimaryAxisAlignment(AutoLayoutAlignment.Center)
                                                .Children
                                                (
                                                    new AutoLayout()
                                                        .Background(Theme.Brushes.Surface.Default)
                                                        .CornerRadius(12)
                                                        .Padding(8, 8, 8, 0)
                                                        .MaxHeight(288)
                                                        .MaxWidth(456)
                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                        .Children
                                                        (
                                                            new Border()
                                                                .Height(204.75)
                                                                .CornerRadius(6)
                                                                .Child
                                                                (
                                                                    new Image()
                                                                        .Source(() => youtubeVideo.Details.Snippet?.Thumbnails?.Medium?.Url!)
                                                                        .Stretch(Stretch.UniformToFill)
                                                                ),
                                                            new AutoLayout()
                                                                .Spacing(8)
                                                                .Orientation(Orientation.Horizontal)
                                                                .Padding(0, 8)
                                                                .Children
                                                                (
                                                                    new Border()
                                                                        .Width(60)
                                                                        .Height(60)
                                                                        .CornerRadius(6)
                                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                                        .Child
                                                                        (
                                                                            new Image()
                                                                                        .Source(() => youtubeVideo.Channel.Snippet?.Thumbnails?.Medium?.Url!)
                                                                                .Stretch(Stretch.UniformToFill)
                                                                        ),
                                                                    new AutoLayout()
                                                                        .PrimaryAxisAlignment(AutoLayoutAlignment.Center)
                                                                        .AutoLayout(primaryAlignment: AutoLayoutPrimaryAlignment.Stretch)
                                                                        .Children
                                                                        (
                                                                            new TextBlock()
                                                                                .Text(() => youtubeVideo.Channel.Snippet?.Title)
                                                                                .Height(22)
                                                                                .Foreground(Theme.Brushes.OnSurface.Default)
                                                                                .Style(Theme.TextBlock.Styles.TitleMedium),
                                                                            new TextBlock()
                                                                                .Text(() => youtubeVideo.Details.Snippet?.Title)
                                                                                .Height(16)
                                                                                .Foreground(Theme.Brushes.OnSurface.Medium)
                                                                        ),
                                                                    new Button()
                                                                        .Foreground(Theme.Brushes.OnSurface.Variant.Default)
                                                                        .Style(Theme.Button.Styles.Icon)
                                                                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                                                                        .Content
                                                                        (
                                                                            new PathIcon()
                                                                                .Data(StaticResource.Get<Geometry>("Icon_Chevron_Right"))
                                                                                .Foreground(Theme.Brushes.OnSurface.Variant.Default)
                                                                        )
                                                                )
                                                        )
                                                )
                                        )
                            )
                    )
            ))
            ;
    }
}