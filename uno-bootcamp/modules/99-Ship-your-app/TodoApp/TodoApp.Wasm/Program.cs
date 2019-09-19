using Uno.UI;
using Windows.UI.Xaml;

namespace TodoApp.Wasm
{
    public class Program
    {
        private static App _app;

        static int Main(string[] args)
        {
#if DEBUG
            // 💡 Enabling enables you to see XAML names directly in the DOM by using the browser F12 tools.
            FeatureConfiguration.UIElement.AssignDOMXamlName = true;
#endif

            Application.Start(_ => _app = new App());

            return 0;
        }
    }
}