#if NET35 || UNITY_5 ||NET40

namespace System
{
#if NETCF
    public interface IProgress<T>
#else
    public interface IProgress<in T>
#endif
    {
        void Report(T value);
    }
}

#endif