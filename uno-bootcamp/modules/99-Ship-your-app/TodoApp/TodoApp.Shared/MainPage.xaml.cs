using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using TodoApp.Shared.Models;
using TodoApp.Shared.ViewModels;

namespace TodoApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ItemClicked(object sender, RoutedEventArgs e)
        {
            var checkBox = sender as CheckBox;
            var todo = checkBox?.DataContext as Todo;
            var isDone = checkBox?.IsChecked ?? false;
            (DataContext as MainPageViewModel)?.ChangeState(todo, isDone);
        }

        private void ChangeItem(object sender, RoutedEventArgs e)
        {
            if (!(sender is TextBlock textBlock)) return;
            if (!(textBlock.Tag is TextBox textBox)) return;

            textBox.Visibility = Visibility.Visible;
            textBlock.Visibility = Visibility.Collapsed;

            textBox.LostFocus += UpdateItem;
            textBox.Focus(FocusState.Programmatic); // give focus

            void UpdateItem(object _, RoutedEventArgs __)
            {
                textBox.Visibility = Visibility.Collapsed;
                textBlock.Visibility = Visibility.Visible;

                var newText = textBox.Text;
                var todo = textBlock?.DataContext as Todo;
                (DataContext as MainPageViewModel)?.ChangeText(todo, newText);

                textBox.LostFocus -= UpdateItem;
            }
        }

        private void ChangeItemBtn(object sender, RoutedEventArgs e)
        {
            if (sender is Button button) ChangeItem(button.Tag, null);
        }

        private void DeleteItem(object sender, RoutedEventArgs e)
        {
            if (DataContext is MainPageViewModel vm)
            {
                var button = sender as FrameworkElement;
                var todo = button?.DataContext as Todo;

                vm.RemoveTodo(todo);
            }
        }

        private void OnNewTodoKey(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Enter)
                if (sender is TextBox textBox)
                {
                    textBox.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();
                    (DataContext as MainPageViewModel)?.CreateNew.Execute(null);
                }
        }

        private void OnItemKey(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key != VirtualKey.Enter) return; // not an enter key

            Focus(FocusState.Programmatic);

            if (sender is TextBox textBox) textBox.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();
        }
    }
}