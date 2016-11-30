#if NET35 || UNITY_5 || NET40

namespace System.Runtime.CompilerServices
{
    /// <summary>
    /// Represents an asynchronous method builder.
    /// </summary>
    internal interface IAsyncMethodBuilder
    {
        void PreBoxInitialization();
    }
}

#endif