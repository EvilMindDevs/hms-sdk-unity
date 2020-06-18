using System;

namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    // Wrapper for com.huawei.hms.jos.games.archive.ArchiveDetails
    public class ArchiveDetails : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public ArchiveDetails(AndroidJavaObject javaObject) : base(javaObject) { }

        public sbyte[] Get() => throw new NotImplementedException();

        public void Set(sbyte[] paramArrayOfByte) => throw new NotImplementedException();

        public bool Update(int paramInt1, sbyte[] paramArrayOfByte, int paramInt2, int paramInt3) => throw new NotImplementedException();
    }

}