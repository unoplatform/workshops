using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TodoApp.Shared.Models;
using Windows.UI.Xaml;

namespace TodoApp.Shared.ViewModels
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private string _newTodoText;
        private State _state = State.Default;
        private int _filter = 0;

        public MainPageViewModel()
        {
            CreateNew = new SimpleCommand(ExecuteCreateNew);
            ViewAll = new SimpleCommand(() => Filter = 0);
            ViewActive = new SimpleCommand(() => throw new NotImplementedException("🎯 Create a `ICommand` that filters the ViewModel to display only Active todos."));
            ViewInactive = new SimpleCommand(() => throw new NotImplementedException("🎯 Create a `ICommand` that filters the ViewModel to display only Inactive todos."));
        }

        public State State
        {
            get => _state;
            private set
            {
                throw new NotImplementedException("🎯 Ensure that updating the `State` property also updates the backing property");
                throw new NotImplementedException("🎯 Ensure that updating the `State` property also invokes `OnPropertyChanged` for `MainPageViewModel` so that databound controls update.");
                throw new NotImplementedException("🎯 Ensure that updating the `State` property also invokes `OnPropertyChanged` for `MainPageViewModel.Todo` so that databound controls update.");
            }
        }

        public Visibility IsEmpty
        {
            get
            {
                if(Todos.Count() == 0)
                {
                    throw new NotImplementedException("🎯 Ensure that the `IsEmpty` property returns the appropriate `Windows.UI.Xaml.Visibility` so that the majority of databound controls disppear when updated.");
                }
                else
                {
                    throw new NotImplementedException("🎯 Ensure that the `IsEmpty` property returns the appropriate `Windows.UI.Xaml.Visibility` so that the majority of databound controls appear when updated.");
                }
            }
        }

        public int Filter
        {
            get => _filter;
            set
            {
                throw new NotImplementedException("🎯 Ensure that updating the `Filter` property also updates the backing property.");
                throw new NotImplementedException("🎯 Ensure that updating the `Filter` property also invokes `OnPropertyChanged` for `MainPageViewModel` so that databound controls update.");
                throw new NotImplementedException("🎯 Ensure that updating the `Filter` property also invokes `OnPropertyChanged` for `MainPageViewModel.Todo` so that databound controls update.");
            }
        } // 0-all, 1-active, 2-inactives

        public IEnumerable<Todo> Todos
        {
            get
            {
                switch (Filter)
                {
                    case 0:
                        return _state.Todos;
                    case 1:
                        throw new NotImplementedException("🎯 Ensure that the `Todos` property returns the appropriate filtered list from `State` when accessed.");
                    case 2:
                        throw new NotImplementedException("🎯 Ensure that the `Todos` property returns the appropriate filtered list from `State` when accessed.");
                }

                throw new InvalidOperationException();
            }
        }

        public string NewTodoText
        {
            get => _newTodoText;
            set
            {
                throw new NotImplementedException("🎯 Ensure that updating the `State` property also updates the backing property");
                throw new NotImplementedException("🎯 Ensure that updating the `State` property also invokes `OnPropertyChanged` for `MainPageViewModel` so that databound controls update.");
            }
        }

        public ICommand CreateNew { get; }

        public ICommand ViewAll { get; }
        public ICommand ViewActive { get; }
        public ICommand ViewInactive { get; }

        private void ExecuteCreateNew()
        {
            var newTodo = new Todo(NewTodoText);
            State = State.WithTodos(todos => todos.Add(newTodo));
            NewTodoText = "";
            OnPropertyChanged();
            OnPropertyChanged(nameof(IsEmpty));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void ChangeState(Todo todo, bool isDone)
        {
            State = State.WithTodos(todos =>
            {
                var existing = todos.FirstOrDefault(t => t.KeyEquals(todo));
                Todo newTodo = existing.WithIsDone(isDone);

                return newTodo != existing ? todos.Replace(existing, newTodo) : todos;
            });
        }

        public void ChangeText(Todo todo, string newText)
        {
            State = State.WithTodos(todos =>
            {
                var existing = todos.FirstOrDefault(t => t.KeyEquals(todo));
                Todo newTodo = existing.WithText(newText);

                throw new NotImplementedException("🎯 Implement `todos.Replace()`");
            });
        }

        public void RemoveTodo(Todo todo)
        {
            State = State.WithTodos(todos =>
            {
                var existing = todos.FirstOrDefault(t => t.KeyEquals(todo));

                throw new NotImplementedException("🎯 Implement `todos.Remove()`");
            });
        }
    }
}
