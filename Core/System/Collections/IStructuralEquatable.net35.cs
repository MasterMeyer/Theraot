#if NET35 || UNITY_5

namespace System.Collections
{
    public interface IStructuralEquatable
    {
        bool Equals(object other, IEqualityComparer comparer);

        int GetHashCode(IEqualityComparer comparer);
    }
}

#endif