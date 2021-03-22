namespace HuaweiMobileServices.Game
{
    using HuaweiMobileServices.Utils;
    using UnityEngine;

    public class GameTrialProcess : JavaObjectWrapper
    {
        [UnityEngine.Scripting.Preserve]
        public GameTrialProcess(AndroidJavaObject javaObject) : base(javaObject) { }

        public virtual void TrialTimeOut()
        {
            
        }
    }
}
