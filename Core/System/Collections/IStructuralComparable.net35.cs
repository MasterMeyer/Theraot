#if NET35 || UNITY_5

namespace System.Collections
{
    public interface IStructuralComparable
    {
        int CompareTo(object other, IComparer comparer);
    }
}

#endif