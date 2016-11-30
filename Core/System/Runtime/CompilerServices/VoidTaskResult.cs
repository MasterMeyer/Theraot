#if NET35 || UNITY_5 || NET40

using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Used with Task(of void)
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Size = 1)]
    internal struct VoidTaskResult
    {
    }
}

#endif