using HuaweiMobileServices.Utils;
using UnityEngine;

namespace HuaweiMobileServices.Location.Location
{
    public class LocationCallback : JavaObjectWrapper
    {
        public LocationCallback(AndroidJavaObject javaObject) : base(javaObject) { }
        private static readonly AndroidJavaClass javaClass = new AndroidJavaClass("com.huawei.hms.location.LocationCallback");

        private class LocationCallbackInterface : AndroidJavaProxy
        {
            private readonly ILocationCallback mListener;

            public LocationCallbackInterface(ILocationCallback listener) : base("org.m0skit0.android.hms.unity.location.LocationCallbackListener")
            {
                mListener = listener;
            }

            public void OnLocationAvailability(LocationAvailability locationAvailability)
            {
                this.CallOnMainThread(() => { mListener.OnLocationAvailability(locationAvailability); });
            }

            public void OnLocationResult(LocationResult locationResult)
            {
                this.CallOnMainThread(() => { mListener.OnLocationResult(locationResult); });
            }



        }
        public LocationCallback(ILocationCallback listener)
       : base("org.m0skit0.android.hms.unity.location.LocationCallbackWrapper", new LocationCallbackInterface(listener)) { }



        //Creator

        //    public LocationCallback() : base("com.huawei.hms.location.LocationCallback") { }





        //  public  void OnLocationAvailability(LocationAvailability locationAvailability) => Call("onLocationAvailability", locationAvailability);

        // public  void OnLocationResult(LocationResult locationResult) => Call("onLocationResult", locationResult);

        /*   public void OnLocationResult(Action onSuccess, Action<HMSException> onFailure)
          {
              CallAsWrapper<TaskAndroidJavaObject>("onLocationResult")
                   .AddOnSuccessListener((intent) =>
                   {
                       var callback = new GenericBridgeCallbackWrapper()
                       .AddOnFailureListener(onFailure)
                       .AddOnSuccessListener((returnedIntent) =>
                       {
                           CallOnMainThread(() => { onSuccess.Invoke(); });
                       });
                       javaClass.CallStatic("receiveShow", intent, callback);
                   }).AddOnFailureListener((exception) => CallOnMainThread(() => { onFailure.Invoke(exception); }));
          }

          public void OnLocationAvailability(Action onSuccess, Action<HMSException> onFailure)
          {
              CallAsWrapper<TaskAndroidJavaObject>("onLocationAvailability")
                   .AddOnSuccessListener((intent) =>
                   {
                       var callback = new GenericBridgeCallbackWrapper()
                       .AddOnFailureListener(onFailure)
                       .AddOnSuccessListener((returnedIntent) =>
                       {
                           CallOnMainThread(() => { onSuccess.Invoke(); });
                       });
                       javaClass.CallStatic("receiveShow", intent, callback);
                   }).AddOnFailureListener((exception) => CallOnMainThread(() => { onFailure.Invoke(exception); }));
          }


          // private static readonly AndroidJavaClass sJavaClass = new AndroidJavaClass("org.m0skit0.android.hms.unity.GenericBridge");



                  public void CallLocationBridge(Action onLocationResult, Action onLocationAvailability)
                  {
                      CallAsWrapper<TaskAndroidJavaObject>("getTotalRankingsIntent")
                          .AddOnSuccessListener((intent) =>
                          {
                              var callback = new GenericBridgeCallbackWrapper()
                                 .AddOnSuccessListener((nothing) =>
                                 {
                                     CallOnMainThread(() => { onLocationResult.Invoke(); });
                                     CallOnMainThread(() => { onLocationAvailability.Invoke(); });
                                 });
                              sJavaClass.CallStatic("receiveShow", intent, callback);

                          }).AddOnFailureListener((exception) => CallOnMainThread(() => {
                              Debug.Log("Exception when CallLocationBridge error:  " + exception.WrappedExceptionMessage);}));
                  }



                  public static void CallLocationBridge(this JavaObjectWrapper javaObjectWrapper, String methodName, Action onLocationResult, Action onLocationAvailability)
                  {
                      javaObjectWrapper.CallAsWrapper<TaskAndroidJavaObject>(methodName)
                          .AddOnSuccessListener((intent) =>
                          {
                              var callback = new LocationCallback()
                             .AddOnFailureListener(onFailure)
                             .AddOnSuccessListener((nothing) =>
                             {
                                 javaObjectWrapper.CallOnMainThread(() => { onLocationResult.Invoke(); });
                             });
                              sJavaClass.CallStatic("receiveShow", intent, callback);

                          }).AddOnFailureListener((exception) => javaObjectWrapper.CallOnMainThread(() => { onFailure.Invoke(exception); }));
                  } */

    }
}

/*
public class LocationCallBackWrapper : LocationCallback
{
    public static double longitude;
    public static double latitude;

    public override void OnLocationResult(LocationResult locationResult)
    {
        Debug.Log("Enes1 OnLocationResult called");
        var ls = locationResult.GetLocations();
        foreach (var l in ls)
        {
            longitude = l.GetLongitude();
            latitude = l.GetLatitude();
            Debug.Log("Enes1 longitude:" + longitude);
            Debug.Log("Enes1 latitude:" + latitude);
        }
    }
    public override void OnLocationAvailability(LocationAvailability locationAvailability)
    {
        Debug.Log("Enes1 OnLocationAvailability called");
        var ls = locationAvailability.IsLocationAvailable;
        Debug.Log("Enes1 locationAvailability is:" + ls);
    }
}
*/