using Microsoft.UI.Xaml;
using Uno.Extensions.Markup;

namespace SimpleCalculator.Styles;

public partial class MaterialFontsOverride : ResourceDictionary
{
	public MaterialFontsOverride()
	{
		this
			.Build
			(
				r => r
					.Add("LabelLargeFontSize",32)
			)
			;
	}
}