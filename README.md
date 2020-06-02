# Unity HMS SDK

Unity C# wrapper SDK for Huawei Mobile Services kits.

Currently these are the kits being integrated:

- Game Service (https://developer.huawei.com/consumer/en/hms/huawei-game)
- In-App Purchases (https://developer.huawei.com/consumer/en/hms/huawei-iap)
- Account (https://developer.huawei.com/consumer/en/hms/huawei-accountkit)
- Ads (https://developer.huawei.com/consumer/en/hms/huawei-adskit)
- Push (https://developer.huawei.com/consumer/en/hms/huawei-pushkit)

## Setup

You need to:

- Import latest DLL and AAR releases of this project to your Unity project.
- Import HMS kit AARs and their dependencies to your Unity project.
- *Optional* Import Play Services AAR and its dependencies to your Unity project. Allows checking if Play Services are available on the device through *HuaweiMobileServices.Base.ServiceHelper* API.
- Tweak AndroidManifest.xml to include HMS-related data (this can be automated using Android Studio and agconnect-services.json).

### Downloading HMS AARs

You need to include the HMS kit AAR and all its dependencies. To download the HMS kit AAR with all its dependencies you can use Gradle with the following build.gradle:

```gradle
apply plugin: 'java'

repositories {
	mavenCentral()
	maven { url 'http://developer.huawei.com/repo/' }
}

dependencies {
  	runtime "com.huawei.hms:$kit:$version"
}

task getDeps(type: Copy) {
  	from sourceSets.main.runtimeClasspath
  	into "./$aarDirectory"	
}
```

And run it like this:

```shell
gradle -Pkit=$KIT_NAME -Pversion=$KIT_VERSION -PaarDirectory=$AAR_DIRECTORY getDeps
```

Where $KIT_NAME is the HMS kit name (e.g. iap), $KIT_VERSION is the HMS kit version (e.g. 4.0.1.300), and $AAR_DIRECTORY is the output directory where to download the AAR and its dependencies. All these AARs must be imported into your Unity project.

### Downloading Play Services AARs

TODO

### Tweak AndroidManifest.xml

TODO

## Usage

This wrapper was designed to be as similar as possible to the original API. It also takes into account C# particularities (e.g. no anonymous classes or interfaces) and transparently provides callbacks for Activity-based flows.

For example, this HMS code (from IAP documentation: https://developer.huawei.com/consumer/en/doc/development/HMS-Guides/iap-development-guide-v4)

```java
// To get the Activity instance that calls this API.
Activity activity = getActivity();
Task<IsEnvReadyResult> task = Iap.getIapClient(activity).isEnvReady();
task.addOnSuccessListener(new OnSuccessListener<IsEnvReadyResult>() {
    @Override
    public void onSuccess(IsEnvReadyResult result) {
        // Obtain the execution result.
    }
}).addOnFailureListener(new OnFailureListener() {
    @Override
    public void onFailure(Exception e) {
        if (e instanceof IapApiException) {
            IapApiException apiException = (IapApiException) e;
            Status status = apiException.getStatus();
            if (status.getStatusCode() == OrderStatusCode.ORDER_HWID_NOT_LOGIN) {
                // Not logged in.
                if (status.hasResolution()) {
                    try {
                        // 6666 is an int constant defined by the developer.
                        status.startResolutionForResult(getActivity(), 6666);
                    } catch (IntentSender.SendIntentException exp) {
                    }
                }
            } else if (status.getStatusCode() == OrderStatusCode.ORDER_ACCOUNT_AREA_NOT_SUPPORTED) {
                // The current region does not support HUAWEI IAP.
            }
        }
    }
});

@Override
protected void onActivityResult(int requestCode, int resultCode, Intent data) {
    super.onActivityResult(requestCode, resultCode, data);
    if (requestCode == 6666) {
        if (data != null) {
            // Obtain the execution result.
            int returnCode = data.getIntExtra("returnCode", 1);
        }
    }
}
```

Becomes

```csharp
var task = Iap.GetIapClient().EnvReady;
// Listeners are Action lambdas, more concise and idiomatic since C#
// does not have anonymous interface implementations.
task.AddOnSuccessListener((isEnvReadyResult) =>
    {
        // Obtain the execution result.
    })
    .AddOnFailureListener((exception) => 
    {
        if (exception.IsIapApiException())
        {
            var iapException = exception.AsIapApiException();
            var status = iapException.Status;
            if (status.StatusCode == OrderStatusCode.ORDER_HWID_NOT_LOGIN)
            {
                if (status.HasResolution())
                {
                    // This call starts a new activity. This wrapper already takes care of bridging
                    // the Android activity workflow transparently using a lambda listener instead.
                    status.StartResolutionForResult(
                        (androidIntent) =>
                        {
                            var errorCode = androidIntent.GetIntExtra("returnCode");
                        },
                        (exception) =>
                        {
                            // Handle the error
                        }
                    );
                }
            }
        }
    }
);
```
