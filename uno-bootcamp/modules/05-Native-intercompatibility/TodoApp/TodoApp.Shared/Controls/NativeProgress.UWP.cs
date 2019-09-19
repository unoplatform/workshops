#if NETFX_CORE
using Windows.UI.Xaml.Controls;

namespace TodoApp.Shared.Controls
{
    /// 📚 <see cref="https://docs.microsoft.com/en-us/uwp/api/windows.ui.xaml.controls.progressbar"/>
    public partial class NativeProgress : ProgressBar
    {
        // Nothing to implement here, we're already using the UWP contract.
    }
}
#endif