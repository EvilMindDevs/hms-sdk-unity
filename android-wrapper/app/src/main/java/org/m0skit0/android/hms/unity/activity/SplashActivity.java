package org.m0skit0.android.hms.unity.activity;

import androidx.annotation.NonNull;

import android.app.Activity;
import android.content.Intent;
import android.content.pm.ActivityInfo;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.os.Message;
import android.util.Log;
import android.view.View;
import android.view.Window;
import android.view.WindowManager;
import android.widget.ImageView;
import android.widget.TextView;

import com.huawei.hms.ads.AdParam;
import com.huawei.hms.ads.AudioFocusType;
import com.huawei.hms.ads.splash.SplashAdDisplayListener;
import com.huawei.hms.ads.splash.SplashView;
import com.unity3d.player.UnityPlayer;
import com.unity3d.player.UnityPlayerActivity;

import org.m0skit0.android.hms.unity.R;
import org.m0skit0.android.hms.unity.ads.SplashAdDisplayListenerWrapper;
import org.m0skit0.android.hms.unity.ads.SplashAdLoadListener;
import org.m0skit0.android.hms.unity.ads.SplashAdLoadListenerWrapper;
import org.w3c.dom.Text;

public class SplashActivity extends Activity {
    private static final String TAG = SplashActivity.class.getSimpleName();

    private static final int AD_TIMEOUT = 10000;

    private static final int MSG_AD_TIMEOUT = 1001;

    private boolean hasPaused = false;

    private Handler mainThreadHandler = new Handler(Looper.getMainLooper());

    private static SplashAdLoadListenerWrapper splashAdLoadListenerWrapper;
    private static SplashAdDisplayListenerWrapper splashAdDisplayListenerWrapper;
    private static AdParam adParam;
    private static String adId;
    private static int orientation;
    private static String title;
    private static String subText;
    private static byte[] imageBytes;
    private SplashView splashView;

    public void load(final AdParam adParameter) {
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                final Intent intent = new Intent(UnityPlayer.currentActivity, SplashActivity.class);
                adParam = adParameter;
                UnityPlayer.currentActivity.startActivity(intent);
            }
        });
    }

    private Handler timeoutHandler = new Handler(new Handler.Callback() {
        @Override
        public boolean handleMessage(@NonNull Message msg) {
            if (SplashActivity.this.hasWindowFocus()) {
                jump();
            }
            return false;
        }
    });

    @Override
    public void onBackPressed() {
    }

    public void setAdId(final String adIdd) {
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                adId = adIdd;
            }
        });
    }

    public void setTitleText(final String value) {
        title = value;
    }

    public void setImage(final byte[] array) {
        imageBytes = array;
    }

    public void setSubText(final String value) {
        subText = value;
    }

    public void setOrientation(final int orientationValue) {
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                orientation = orientationValue;
            }
        });
    }

    public void setSplashAdLoadListener(final SplashAdLoadListenerWrapper listener) {
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                splashAdLoadListenerWrapper = listener;
            }
        });
    }

    public void setSplashAdDisplayListener(final org.m0skit0.android.hms.unity.ads.SplashAdDisplayListenerWrapper listener) {
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                splashAdDisplayListenerWrapper = listener;
            }
        });
    }


    private SplashView.SplashAdLoadListener splashAdLoadListener = new SplashView.SplashAdLoadListener() {
        @Override
        public void onAdLoaded() {
            mainThreadHandler.post((new Runnable() {
                @Override
                public void run() {
                    findViewById(R.id.logo_area).setVisibility(View.VISIBLE);
                    if (splashAdLoadListenerWrapper != null)
                        splashAdLoadListenerWrapper.onAdLoaded();
                    Log.i(TAG, "SplashAdLoadListener onAdLoaded.");
                }
            }));
        }

        @Override
        public void onAdFailedToLoad(final int errorCode) {
            mainThreadHandler.post((new Runnable() {
                @Override
                public void run() {
                    Log.i(TAG, "SplashAdLoadListener onAdFailedToLoad, errorCode: " + errorCode);
                    if (splashAdLoadListenerWrapper != null)
                        splashAdLoadListenerWrapper.onAdFailedToLoad(errorCode);
                    jump();
                }
            }));
        }

        @Override
        public void onAdDismissed() {
            mainThreadHandler.post((new Runnable() {
                @Override
                public void run() {
                    Log.i(TAG, "SplashAdLoadListener onAdDismissed.");
                    if (splashAdLoadListenerWrapper != null)
                        splashAdLoadListenerWrapper.onAdDismissed();
                    jump();
                }

            }));
        }
    };

    private SplashAdDisplayListener adDisplayListener = new SplashAdDisplayListener() {
        @Override
        public void onAdShowed() {
            mainThreadHandler.post(new Runnable() {
                @Override
                public void run() {
                    Log.i(TAG, "SplashAdDisplayListener onAdShowed.");
                    if (splashAdDisplayListenerWrapper != null)
                        splashAdDisplayListenerWrapper.onAdShowed();
                }
            });
        }

        @Override
        public void onAdClick() {
            mainThreadHandler.post(new Runnable() {
                @Override
                public void run() {
                    Log.i(TAG, "SplashAdDisplayListener onAdClick.");
                    if (splashAdDisplayListenerWrapper != null)
                        splashAdDisplayListenerWrapper.onAdClick();
                }
            });

        }
    };

    private void loadAd() {
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                Log.e(TAG, "Start to load splash ad");

                splashView = findViewById(R.id.splash_ad_view);
                splashView.setAdDisplayListener(adDisplayListener);
                ((TextView) findViewById(R.id.titleText)).setText(title);
                ((TextView) findViewById(R.id.subText)).setText(subText);
                if (imageBytes != null && imageBytes.length > 0)
                    ((ImageView) findViewById(R.id.imageView)).setImageBitmap(BitmapFactory.decodeByteArray(imageBytes, 0, imageBytes.length));
                // Set a default app launch image.
                //splashView.setLogo(findViewById(R.id.logo_area));
                // Set a logo image.
                //splashView.setLogoResId();
                //splashView.setLogoResId(R.mipmap.ic_launcher);
                // Set logo description.
                //splashView.setMediaNameResId(R.string.media_name);
                // Set the audio focus type for a video splash ad.
                splashView.setAudioFocusType(AudioFocusType.NOT_GAIN_AUDIO_FOCUS_WHEN_MUTE);
                Log.e(TAG, "Loading ad with id: " + adId + " orientation: " + orientation);
                splashView.load(adId, orientation, new AdParam.Builder().build(), splashAdLoadListener);
                Log.e(TAG, "End to load splash ad");

                // Remove the timeout message from the message queue.
                timeoutHandler.removeMessages(MSG_AD_TIMEOUT);
                // Send a delay message to ensure that the app home screen can be displayed when the ad display times out.
                timeoutHandler.sendEmptyMessageDelayed(MSG_AD_TIMEOUT, AD_TIMEOUT);
            }
        });
    }

    private void jump() {
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                Log.i(TAG, "jump hasPaused: " + hasPaused);
                if (!hasPaused) {
                    hasPaused = true;
                    Log.i(TAG, "jump into application");
                    finish();
                }
            }
        });
    }

    private void removeReferences() {
        splashAdLoadListenerWrapper = null;
        splashAdDisplayListenerWrapper = null;
        adParam = null;
        adId = null;
    }

    @Override
    protected void onCreate(final Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        requestWindowFeature(Window.FEATURE_NO_TITLE);
        Log.e(TAG, "onCreate got called dude");
        //HwAds.init(this);
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                setContentView(R.layout.activity_splash);
                loadAd();
            }
        });
    }

    @Override
    protected void onStop() {
        super.onStop();
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                Log.i(TAG, "SplashActivity onStop.");
                timeoutHandler.removeMessages(MSG_AD_TIMEOUT);
                hasPaused = true;
            }
        });
    }

    @Override
    protected void onRestart() {
        super.onRestart();
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                Log.i(TAG, "SplashActivity onRestart.");
                hasPaused = false;
                jump();
            }
        });
    }

    @Override
    protected void onDestroy() {
        super.onDestroy();
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                Log.i(TAG, "SplashActivity onDestroy.");
                if (splashView != null) {
                    splashView.destroyView();
                }
                removeReferences();
            }
        });
    }

    @Override
    protected void onPause() {
        super.onPause();
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                Log.i(TAG, "SplashActivity onPause.");
                if (splashView != null) {
                    splashView.pauseView();
                }
            }
        });
    }

    @Override
    protected void onResume() {
        super.onResume();
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                Log.i(TAG, "SplashActivity onResume.");
                if (splashView != null) {
                    splashView.resumeView();
                }
            }
        });
    }
}