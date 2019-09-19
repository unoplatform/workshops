using Windows.UI.Xaml;

namespace TodoApp.Shared.Controls
{
#if !NETFX_CORE
    public partial class NativeProgress
    {
        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register(
            nameof(Value), typeof(double), typeof(NativeProgress), new PropertyMetadata(50.0d, OnValueChanged));

        public static readonly DependencyProperty MinProperty = DependencyProperty.Register(
            nameof(Minimum), typeof(double), typeof(NativeProgress), new PropertyMetadata(0d, OnMinChanged));

        public static readonly DependencyProperty MaxProperty = DependencyProperty.Register(
            nameof(Maximum), typeof(double), typeof(NativeProgress), new PropertyMetadata(100.0d, OnMaxChanged));

        public double Value
        {
            get => (double) GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }

        public double Minimum
        {
            get => (double) GetValue(MinProperty);
            set => SetValue(MinProperty, value);
        }

        public double Maximum
        {
            get => (double) GetValue(MaxProperty);
            set => SetValue(MaxProperty, value);
        }
    }
#endif
}