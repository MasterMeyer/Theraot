﻿#if NET35 || UNITY_5 || NET40

using System.Security;

namespace System.Runtime.CompilerServices
{
    public interface ICriticalNotifyCompletion : INotifyCompletion
    {
        [SecurityCritical]
        void UnsafeOnCompleted(Action continuation);
    }
}

#endif