using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Media;
using System;
using Uno.Extensions.Markup;
using Uno.Material;
using Uno.Toolkit.UI;

namespace SimpleCalculator;

public partial class MainPage : Page
{
	public MainPage()
	{
		this
			.Background(Theme.Brushes.Background.Default)
			.StatusBar(foreground: StatusBarForegroundTheme.Light)
			.Resources
			(
				r => r
					.Add("Icon_MoonIcon","F1 M 10.34000015258789 0.006284978240728378 C 4.590000152587891 -0.19371502473950386 0 4.406285285949707 0 9.986285209655762 C 0 15.506285190582275 4.480000019073486 19.986284255981445 10 19.986284255981445 C 13.710000038146973 19.986284255981445 16.929999828338623 17.96628475189209 18.65999984741211 14.96628475189209 C 11.149999618530273 14.71628475189209 6.570000171661377 6.536285188049078 10.34000015258789 0.006284978240728378 Z")
					.Add("Icon_SunIcon","F1 M 5.760000228881836 4.289999961853027 L 3.9600000381469727 2.5 L 2.549999952316284 3.9100000858306885 L 4.340000152587891 5.699999809265137 L 5.760000228881836 4.289999961853027 Z M 3 9.949999809265137 L 0 9.949999809265137 L 0 11.949999809265137 L 3 11.949999809265137 L 3 9.949999809265137 Z M 12 0 L 10 0 L 10 2.950000047683716 L 12 2.950000047683716 L 12 0 L 12 0 Z M 19.450000762939453 3.9100000858306885 L 18.040000915527344 2.5 L 16.25 4.289999961853027 L 17.65999984741211 5.699999809265137 L 19.450000762939453 3.9100000858306885 Z M 16.239999771118164 17.610000610351562 L 18.030000686645508 19.40999984741211 L 19.440000534057617 18 L 17.639999389648438 16.21000099182129 L 16.239999771118164 17.610000610351562 Z M 19 9.949999809265137 L 19 11.949999809265137 L 22 11.949999809265137 L 22 9.949999809265137 L 19 9.949999809265137 Z M 11 4.949999809265137 C 7.690000057220459 4.949999809265137 5 7.639999866485596 5 10.949999809265137 C 5 14.259999752044678 7.690000057220459 16.950000762939453 11 16.950000762939453 C 14.309999942779541 16.950000762939453 17 14.259999752044678 17 10.949999809265137 C 17 7.639999866485596 14.309999942779541 4.949999809265137 11 4.949999809265137 Z M 10 21.900001525878906 L 12 21.900001525878906 L 12 18.950000762939453 L 10 18.950000762939453 L 10 21.900001525878906 Z M 2.549999952316284 17.990001678466797 L 3.9600000381469727 19.400001525878906 L 5.75 17.600000381469727 L 4.340000152587891 16.190000534057617 L 2.549999952316284 17.990001678466797 Z")
			)
			.Content
			(
				new AutoLayout()
					.Background(Theme.Brushes.Secondary.Container.Default)
					.Children
					(
						new AutoLayout()
							.MaxWidth(700)
							.AutoLayout(primaryAlignment: AutoLayoutPrimaryAlignment.Stretch)
							.Children
							(
								new ToggleButton()
									.Background(Theme.Brushes.Surface.Default)
									.Margin(10,24)
									.CornerRadius(20)
									.AutoLayout(counterAlignment: AutoLayoutAlignment.Center)
									.Content
									(
										new PathIcon()
											.Data(StaticResource.Get<Geometry>("Icon_SunIcon"))
											.Foreground(Theme.Brushes.Primary.Default)
									)
									.ControlExtensions
									(
										alternateContent:
											new PathIcon()
												.Data(StaticResource.Get<Geometry>("Icon_MoonIcon"))
												.Foreground(Theme.Brushes.Primary.Default)
									),
								new AutoLayout()
									.Spacing(16)
									.PrimaryAxisAlignment(AutoLayoutAlignment.End)
									.Padding(16,8)
									.MinHeight(120)
									.AutoLayout(primaryAlignment: AutoLayoutPrimaryAlignment.Stretch)
									.Children
									(
										new TextBlock()
											.Text(b => b.Binding("Calculator.Equation"))
											.Foreground(Theme.Brushes.OnSecondary.Container.Default)
											.Style(Theme.TextBlock.Styles.DisplaySmall)
											.AutoLayout(counterAlignment: AutoLayoutAlignment.End),
										new TextBlock()
											.Text(b => b.Binding("Calculator.Output"))
											.Foreground(Theme.Brushes.OnBackground.Default)
											.Style(Theme.TextBlock.Styles.DisplayLarge)
											.AutoLayout(counterAlignment: AutoLayoutAlignment.End)
									),
								new AutoLayout()
									.Spacing(16)
									.PrimaryAxisAlignment(AutoLayoutAlignment.End)
									.Padding(16)
									.Children
									(
										new AutoLayout()
											.Spacing(16)
											.Orientation(Orientation.Horizontal)
											.Height(72)
											.Children
											(
												new Button()
													.Background(Theme.Brushes.OnSurface.Inverse.Default)
													.Content("C")
													.Height(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Background(Theme.Brushes.OnSurface.Inverse.Default)
													.Content("+/-")
													.Height(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Background(Theme.Brushes.OnSurface.Inverse.Default)
													.Content("%")
													.Height(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Content("÷")
													.Height(72)
													.CornerRadius(24)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													)
											),
										new AutoLayout()
											.Spacing(16)
											.Orientation(Orientation.Horizontal)
											.Height(72)
											.Children
											(
												new Button()
													.Background(Theme.Brushes.Surface.Default)
													.Content("7")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Background(Theme.Brushes.Surface.Default)
													.Content("8")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Background(Theme.Brushes.Surface.Default)
													.Content("9")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Content("×")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													)
											),
										new AutoLayout()
											.Spacing(16)
											.Orientation(Orientation.Horizontal)
											.Height(72)
											.Children
											(
												new Button()
													.Background(Theme.Brushes.Surface.Default)
													.Content("4")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Background(Theme.Brushes.Surface.Default)
													.Content("5")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Background(Theme.Brushes.Surface.Default)
													.Content("6")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Content("−")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													)
											),
										new AutoLayout()
											.Spacing(16)
											.Orientation(Orientation.Horizontal)
											.Height(72)
											.Children
											(
												new Button()
													.Background(Theme.Brushes.Surface.Default)
													.Content("1")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Background(Theme.Brushes.Surface.Default)
													.Content("2")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Background(Theme.Brushes.Surface.Default)
													.Content("3")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Content("+")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													)
											),
										new AutoLayout()
											.Spacing(16)
											.Orientation(Orientation.Horizontal)
											.Height(72)
											.Children
											(
												new Button()
													.Background(Theme.Brushes.Surface.Default)
													.Content(".")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Background(Theme.Brushes.Surface.Default)
													.Content("0")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Background(Theme.Brushes.Surface.Default)
													.Content("⌫")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.Style(Theme.Button.Styles.FilledTonal)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													),
												new Button()
													.Content("=")
													.Height(72)
													.MinWidth(72)
													.CornerRadius(24)
													.AutoLayout
													(
														counterAlignment: AutoLayoutAlignment.Start,
														primaryAlignment: AutoLayoutPrimaryAlignment.Stretch
													)
											)
									)
							)
					)
			)
			;
	}
}