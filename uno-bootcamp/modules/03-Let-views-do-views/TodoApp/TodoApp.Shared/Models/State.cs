using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using Uno;

/// 💡 <summary>
///     `[GeneratedImmutable]`, `[EqualityKey]` and `[EqualityIgnore]` come from an optional but recommended dependency
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
namespace TodoApp.Shared.Models
{
    [GeneratedImmutable]
    public partial class State
    {
        [EqualityHash]
        public ImmutableArray<Todo> Todos { get; } = ImmutableArray<Todo>.Empty;

        [EqualityIgnore]
        public int RemainingTodos => ActiveTodos.Count();

        [EqualityIgnore]
        public IEnumerable<Todo> ActiveTodos => Todos.Where(t => !t.IsDone);

        [EqualityIgnore]
        public IEnumerable<Todo> InactiveTodos => Todos.Where(t => t.IsDone);
    }
}