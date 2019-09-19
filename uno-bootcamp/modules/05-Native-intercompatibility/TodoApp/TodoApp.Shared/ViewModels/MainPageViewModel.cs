using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Windows.UI.Xaml;
using TodoApp.Shared.Models;

namespace TodoApp.Shared.ViewModels
{
    /// <summary>
    /// ViewModel for main page (the only one yet) for the TodoApp
    /// </summary>
    public class MainPageViewModel : INotifyPropertyChanged
    {
        private int _filter;
        private string _newTodoText;
        private State _state = State.Default;

        public MainPageViewModel()
        {
            // Create commands
            CreateNew = new SimpleCommand(ExecuteCreateNew);
            ViewAll = new SimpleCommand(() => Filter = 0);
            ViewActive = new SimpleCommand(() => Filter = 1);
            ViewInactive = new SimpleCommand(() => Filter = 2);
        }

        public State State
        {
            get => _state;
            private set
            {
                _state = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Todos));
            }
        }

        public int Filter
        {
            get => _filter;
            set
            {
                _filter = value;
                OnPropertyChanged();
                OnPropertyChanged(nameof(Todos));
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
                        return _state.ActiveTodos;
                    case 2:
                        return _state.InactiveTodos;
                }

                throw new InvalidOperationException();
            }
        }

        public string NewTodoText
        {
            get => _newTodoText;
            set
            {
                _newTodoText = value;
                OnPropertyChanged();
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
            if (string.IsNullOrWhiteSpace(newText))
            {
                // If the user removed all the text of a todo,
                // treat it as a delete
                RemoveTodo(todo);
                return;
            }

            State = State.WithTodos(todos =>
            {
                var existing = todos.FirstOrDefault(t => t.KeyEquals(todo));
                Todo newTodo = existing.WithText(newText);
                return newTodo != existing ? todos.Replace(existing, newTodo) : todos;
            });
        }

        public void RemoveTodo(Todo todo)
        {
            State = State.WithTodos(todos =>
            {
                var existing = todos.FirstOrDefault(t => t.KeyEquals(todo));
                return existing != null ? todos.Remove(existing) : todos;
            });
        }
    }
}