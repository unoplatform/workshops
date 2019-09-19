using System;
using System.Windows.Input;

namespace TodoApp.Shared.ViewModels
{
    /// <summary>
    /// Simple naive implementation of ICommand for demo purposes
    /// </summary>
    internal class SimpleCommand : ICommand
    {
        private readonly Action _action;

        public SimpleCommand(Action action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _action();
        }

        public event EventHandler CanExecuteChanged;
    }

    /// <summary>
    /// Simple naive implementation of ICommand for demo purposes
    /// </summary>
    internal class SimpleCommand<T> : ICommand where T : class
    {
        private readonly Action<T> _action;

        public SimpleCommand(Action<T> action)
        {
            _action = action;
        }

        public bool CanExecute(object parameter)
        {
            return parameter is T;
        }

        public void Execute(object parameter)
        {
            _action(parameter as T);
        }

        public event EventHandler CanExecuteChanged;
    }
}