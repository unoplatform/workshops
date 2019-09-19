using System;
using Uno;

namespace TodoApp.Shared.Models
{
    /// 💡 <summary>
    ///     [GeneratedImmutable] and [EqualityKey] come from an optional but recommended dependency
    ///     called `Uno.CodeGen` which is a set of tools to generate C# code in msbuild based projects.
    ///     
    ///     Features:
    ///     - Amazingly fast: absolutely zero reflection at runtime
    ///     - Generates both.Equals() and.GetHashCode() overrrides
    ///     - Generates equality(== and !=) operators
    ///     - Implements IEquatable<T>
    ///     - Works with derived classes
    ///     - Custom comparers supported
    ///     - Works with collection members(both same order and unsorted equality)
    ///     - Works with dictionary members(both same order and unsorted equality)
    ///     - Optional case insentive comparisons for strings
    ///     - Optional support for KeyEquality(see doc for more details)
    ///     - Debuggable: You can put a breakpoint directly in the generated code
    ///     - Highly configureable: Generated code provides a lot of useful tips(stripped in previous snippet)
    ///     - Documentation here for Equality Members Generator
    /// </summary>
    /// 📚 <seealso cref="https://github.com/unoplatform/Uno.CodeGen"/>
    [GeneratedImmutable]
    public partial class Todo
    {
        public Todo(string text)
        {
            Text = text;
        }

        [EqualityKey] public Guid Id { get; } = Guid.NewGuid();

        public bool IsDone { get; }

        public string Text { get; }
    }
}