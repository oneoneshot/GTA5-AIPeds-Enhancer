using System.ComponentModel;

/*
 * The purpose of MarkerClass.cs is to provide compatibility support for language features
 * and attributes that are not available in earlier versions of .NET. This file defines
 * several types and attributes that enable newer C# language features to be used in projects
 * targeting older versions of the .NET framework.
 *
 * These conditional definitions ensure that codebases can leverage modern C# features while
 * maintaining backward compatibility with older .NET runtimes.
 */

namespace System.Runtime.CompilerServices
{
#if !NET5_0_OR_GREATER

    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static class IsExternalInit { }

#endif // !NET5_0_OR_GREATER

#if !NET7_0_OR_GREATER

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
    internal sealed class RequiredMemberAttribute : 