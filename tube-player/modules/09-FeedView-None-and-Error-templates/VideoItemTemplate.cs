public static UIElement VideoItemTemplate(YoutubeVideo youtubeVideo) =>
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
        );