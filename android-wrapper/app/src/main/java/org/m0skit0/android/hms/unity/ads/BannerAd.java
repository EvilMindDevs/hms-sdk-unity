package org.m0skit0.android.hms.unity.ads;

import android.app.Activity;
import android.graphics.Color;
import android.os.Handler;
import android.os.Looper;
import android.text.TextUtils;
import android.util.DisplayMetrics;
import android.view.View;
import android.view.ViewGroup;
import android.view.ViewParent;
import android.widget.FrameLayout;

import com.huawei.hms.ads.AdListener;
import com.huawei.hms.ads.AdParam;
import com.huawei.hms.ads.BannerAdSize;
import com.huawei.hms.ads.banner.BannerView;

import org.m0skit0.android.hms.unity.ads.Constants.UnityBannerAdPositionCode;
import org.m0skit0.android.hms.unity.ads.Constants.UnityBannerAdSize;


public class BannerAd extends AdListener {
    private static final int DEFAULT_WIDTH = 320;

    private Activity activity;

    private BannerView bannerView;

    private org.m0skit0.android.hms.unity.ads.AdListener adListener;

    private Handler mainThreadHandler = new Handler(Looper.getMainLooper());

    private String adId;

    private String adSizeType = UnityBannerAdSize.USER_DEFINED;

    private long bannerRefresh = 60;

    private int positionCode = UnityBannerAdPositionCode.POSITION_TOP;

    private int horizontalOffset = 0;

    private int verticalOffset = 0;

    private boolean isHide = false;

    private int customWidth = DEFAULT_WIDTH;

    public BannerAd(Activity activity, org.m0skit0.android.hms.unity.ads.AdListener listener) {
        this.activity = activity;
        adListener = listener;
    }

    public void setAdId(String adId) {
        this.adId = adId;
    }

    public void setAdSizeType(String adSizeType) {
        this.adSizeType = adSizeType;
    }

    private BannerAdSize getTargetBannerAdSize(String adSize) {
        BannerAdSize bannerAdSize = BannerAdSize.BANNER_SIZE_INVALID;
        switch (adSize) {
            case UnityBannerAdSize.USER_DEFINED:
                bannerAdSize = getUserDefinedBannerSize();
                break;
            case UnityBannerAdSize.BANNER_SIZE_320_50:
                bannerAdSize = BannerAdSize.BANNER_SIZE_320_50;
                break;
            case UnityBannerAdSize.BANNER_SIZE_320_100:
                bannerAdSize = BannerAdSize.BANNER_SIZE_320_100;
                break;
            case UnityBannerAdSize.BANNER_SIZE_468_60:
                bannerAdSize = BannerAdSize.BANNER_SIZE_468_60;
                break;
            case UnityBannerAdSize.BANNER_SIZE_DYNAMIC:
                bannerAdSize = BannerAdSize.BANNER_SIZE_DYNAMIC;
                break;
            case UnityBannerAdSize.BANNER_SIZE_728_90:
                bannerAdSize = BannerAdSize.BANNER_SIZE_728_90;
                break;
            case UnityBannerAdSize.BANNER_SIZE_300_250:
                bannerAdSize = BannerAdSize.BANNER_SIZE_300_250;
                break;
            case UnityBannerAdSize.BANNER_SIZE_SMART:
                bannerAdSize = BannerAdSize.BANNER_SIZE_SMART;
                break;
            case UnityBannerAdSize.BANNER_SIZE_160_600:
                bannerAdSize = BannerAdSize.BANNER_SIZE_160_600;
                break;
            case UnityBannerAdSize.BANNER_SIZE_360_57:
                bannerAdSize = BannerAdSize.BANNER_SIZE_360_57;
                break;
            case UnityBannerAdSize.BANNER_SIZE_360_144:
                bannerAdSize = BannerAdSize.BANNER_SIZE_360_144;
                break;
            default:
                break;
        }
        return bannerAdSize;
    }

    private BannerAdSize getUserDefinedBannerSize() {
        return BannerAdSize.getCurrentDirectionBannerSize(activity, customWidth);
    }

    public void loadAd(final AdParam adRequest) {
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                if (bannerView == null) {
                    bannerView = new BannerView(activity);
                    bannerView.setBackgroundColor(Color.TRANSPARENT);
                    bannerView.setVisibility(View.GONE);
                    bannerView.setAdListener(BannerAd.this);
                    bannerView.setBannerRefresh(bannerRefresh);
                    activity.addContentView(bannerView, getBannerViewLayoutParams());
                }
                bannerView.setAdId(adId);
                bannerView.setBannerAdSize(getTargetBannerAdSize(adSizeType));
                if (BannerAdSize.BANNER_SIZE_INVALID.equals(bannerView.getBannerAdSize())) {
                    return;
                }

                if (TextUtils.isEmpty(bannerView.getAdId())) {
                    return;
                }
                bannerView.loadAd(adRequest);
            }
        });
    }

    public void setCustomSize(int size) {
        customWidth = size;
    }

    private FrameLayout.LayoutParams getBannerViewLayoutParams() {
        final FrameLayout.LayoutParams adParams =
                new FrameLayout.LayoutParams(FrameLayout.LayoutParams.WRAP_CONTENT, FrameLayout.LayoutParams.WRAP_CONTENT);
        adParams.gravity = UnityBannerAdPositionCode.getLayoutGravityForPositionCode(positionCode);
        int safeInsetLeft = 0;
        int safeInsetTop = 0;
        if (positionCode == UnityBannerAdPositionCode.POSITION_CUSTOM) {
            int leftOffset = (int) convertDpToPx(horizontalOffset);
            if (leftOffset < safeInsetLeft) {
                leftOffset = safeInsetLeft;
            }
            int topOffset = (int) convertDpToPx(verticalOffset);
            if (topOffset < safeInsetTop) {
                topOffset = safeInsetTop;
            }
            adParams.leftMargin = leftOffset;
            adParams.topMargin = topOffset;
        } else {
            adParams.leftMargin = safeInsetLeft;
            if (positionCode == UnityBannerAdPositionCode.POSITION_TOP
                    || positionCode == UnityBannerAdPositionCode.POSITION_TOP_LEFT
                    || positionCode == UnityBannerAdPositionCode.POSITION_TOP_RIGHT) {
                adParams.topMargin = safeInsetTop;
            }
        }
        return adParams;
    }

    public void show() {
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                isHide = false;
                if (bannerView != null) {
                    bannerView.resume();
                    bannerView.setVisibility(View.VISIBLE);
                }
            }
        });
    }

    public void hide() {
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                isHide = true;
                if (bannerView != null) {
                    bannerView.pause();
                    bannerView.setVisibility(View.GONE);
                }
            }
        });
    }

    public void destroy() {
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                if (bannerView != null) {
                    bannerView.destroy();
                    bannerView.setVisibility(View.GONE);
                    ViewParent parentView = bannerView.getParent();
                    if (parentView instanceof ViewGroup) {
                        ((ViewGroup) parentView).removeView(bannerView);
                    }
                }
                bannerView = null;
            }
        });
    }

    public void setBannerAdPosition(final int positionX, final int positionY) {
        positionCode = UnityBannerAdPositionCode.POSITION_CUSTOM;
        horizontalOffset = positionX;
        verticalOffset = positionY;
        updatePosition();
    }

    public void setBannerRefresh(long interval) {
        bannerRefresh = interval;
        if (bannerView != null)
            bannerView.setBannerRefresh(interval);
    }

    public void setBannerAdPosition(final int positionCode) {
        this.positionCode = positionCode;
        horizontalOffset = 0;
        verticalOffset = 0;
        updatePosition();
    }

    private void updatePosition() {
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                if (bannerView == null) {
                    return;
                }
                FrameLayout.LayoutParams layoutParams = getBannerViewLayoutParams();
                bannerView.setLayoutParams(layoutParams);
            }
        });
    }

    @Override
    public void onAdClosed() {
        super.onAdClosed();
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                if (adListener != null) {
                    adListener.onAdClosed();
                }
            }
        });
    }

    @Override
    public void onAdFailed(final int i) {
        super.onAdFailed(i);
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                if (adListener != null) {
                    adListener.onAdFailed(i);
                }
            }
        });
    }

    @Override
    public void onAdLeave() {
        super.onAdLeave();
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                if (adListener != null) {
                    adListener.onAdLeave();
                }
            }
        });
    }

    @Override
    public void onAdOpened() {
        super.onAdOpened();
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                if (adListener != null) {
                    adListener.onAdOpened();
                }
            }
        });
    }

    @Override
    public void onAdLoaded() {
        super.onAdLoaded();
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                if (!isHide && bannerView != null) {
                    show();
                }
                if (adListener != null) {
                    adListener.onAdLoaded();
                }
            }
        });
    }

    @Override
    public void onAdClicked() {
        super.onAdClicked();
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                if (adListener != null) {
                    adListener.onAdClicked();
                }
            }
        });
    }

    @Override
    public void onAdImpression() {
        super.onAdImpression();
        mainThreadHandler.post(new Runnable() {
            @Override
            public void run() {
                if (adListener != null) {
                    adListener.onAdImpression();
                }
            }
        });
    }

    private float convertDpToPx(float dp) {
        DisplayMetrics metrics = activity.getResources().getDisplayMetrics();
        return dp * metrics.density;
    }
}
