public static UIElement VideoErrorTemplate() =>
    new AutoLayout()
        .Spacing(8)
        .PrimaryAxisAlignment(AutoLayoutAlignment.Center)
        .AutoLayout(primaryAlignment: AutoLayoutPrimaryAlignment.Stretch)
        .Children
        (
            new AutoLayout()
                .Spacing(24)
                .PrimaryAxisAlignment(AutoLayoutAlignment.Center)
                .Padding(0, 0, 0, 36)
                .AutoLayout
                (
                    counterAlignment: AutoLayoutAlignment.Center,
                    primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
                )
                .Children
                (
                    new AutoLayout()
                        .Spacing(10)
                        .PrimaryAxisAlignment(AutoLayoutAlignment.Center)
                        .Width(160)
                        .Height(160)
                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                        .Children
                        (
                            new Ellipse()
                                .Fill(Theme.Brushes.Surface.Default)
                                .Width(160)
                                .Height(160)
                                .AutoLayout(counterAlignment: AutoLayoutAlignment.Center),
                            new Path()
                                .Data("F1 M 78.19999694824219 1.8000001907348633 C 77.19999694824219 0.6000001430511475 75.60000002384186 0 74 0 L 6 0 C 4.399999976158142 0 2.8000001907348633 0.6000001430511475 1.8000001907348633 1.8000001907348633 C 0.6000001430511475 2.8000001907348633 0 4.399999976158142 0 6 L 0 58 C 0 59.60000002384186 0.6000001430511475 61.19999694824219 1.8000001907348633 62.19999694824219 C 2.8000001907348633 63.3999969959259 4.399999976158142 64 6 64 L 74 64 C 77.20000004768372 64 80 61.200000047683716 80 58 L 80 6 C 80 4.399999976158142 79.3999969959259 2.8000001907348633 78.19999694824219 1.8000001907348633 Z M 74 58 L 6 58 L 6 6 L 74 6 L 74 58 Z M 30.799999237060547 45.400001525878906 L 40 36.20000076293945 L 49.20000076293945 45.400001525878906 L 53.400001525878906 41.20000076293945 L 44.20000076293945 32 L 53.400001525878906 22.799999237060547 L 49.20000076293945 18.600000381469727 L 40 27.799999237060547 L 30.799999237060547 18.600000381469727 L 26.600000381469727 22.799999237060547 L 35.79999923706055 32 L 26.600000381469727 41.20000076293945 L 30.799999237060547 45.400001525878906 Z")
                                .Fill(Theme.Brushes.Secondary.Default)
                                .Margin(40, 48)
                                .VerticalAlignment(VerticalAlignment.Center)
                                .HorizontalAlignment(HorizontalAlignment.Center)
                                .Width(80)
                                .Height(64)
                                .AutoLayout(isIndependentLayout: true)
                        ),
                    new AutoLayout()
                        .PrimaryAxisAlignment(AutoLayoutAlignment.Center)
                        .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                        .Children
                        (
                            new TextBlock()
                                .Text("Oh no!")
                                .Foreground(Theme.Brushes.OnSurface.Default)
                                .Style(Theme.TextBlock.Styles.HeadlineSmall)
                                .AutoLayout(counterAlignment: AutoLayoutAlignment.Center),
                            new TextBlock()
                                .Text("Something went wrong")
                                .Foreground(Theme.Brushes.OnSurface.Medium)
                                .Style(Theme.TextBlock.Styles.BodyLarge)
                                .AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
                        )
                ),
            new Button()
                .Content("Retry")
                .Margin(16, 24)
                .Style(Theme.Button.Styles.FilledTonal)
                .ControlExtensions
                (
                    icon:
                        new PathIcon()
                            .Data(StaticResource.Get<Geometry>("Icon_Refresh"))
                )
        );