using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class Reklamy : MonoBehaviour {

    string appId = "ca-app-pub-5708702788155264~1800130047";
    static string FullscreenAdID = "ca-app-pub-3940256099942544/1033173712"; //test fullscreenAd
    static string BannerAdID = "ca-app-pub-3940256099942544/6300978111"; //test banner
    static string RewardAdID = "ca-app-pub-3940256099942544/5224354917"; //test reward
    InterstitialAd fullscreenAd;
    BannerView bannerAd;
    RewardBasedVideoAd rewardAd;



    void Start () {
        MobileAds.Initialize(appId);
        RequestReward();
        rewardAd.OnAdClosed += HandleRewardBasedVideoClosed;
    }
    private void Update()
    {
        ShowFullscreen();
    }

    public void RequestInterstitial() //fullscreen
    {
        fullscreenAd = new InterstitialAd(FullscreenAdID);

        //// Create an empty ad request.
        AdRequest request = new AdRequest.Builder().AddTestDevice("9A0B0887482D275C7DECFD2B3B31FC57").Build();

        // Load the interstitial with the request.
        fullscreenAd.LoadAd(request);
    }
    public void ShowFullscreen()
    {
        if (fullscreenAd.IsLoaded())
            fullscreenAd.Show();
   }
    public void RequestBanner() //banner
    {
        bannerAd = new BannerView(BannerAdID,AdSize.Banner,AdPosition.Top);

        //// Create an empty ad request.
        AdRequest request = new AdRequest.Builder().AddTestDevice("9A0B0887482D275C7DECFD2B3B31FC57").Build();

        // Load the interstitial with the request.
        bannerAd.LoadAd(request);

        bannerAd.Show();

    }
    public void RequestReward() //reward
    {
        rewardAd = RewardBasedVideoAd.Instance;
        //// Create an empty ad request.
        AdRequest request = new AdRequest.Builder().AddTestDevice("9A0B0887482D275C7DECFD2B3B31FC57").Build();

        // Load the interstitial with the request.
        rewardAd.LoadAd(request, RewardAdID);

    }
    public void ShowReward()
    {
        if (rewardAd.IsLoaded())
            rewardAd.Show();
    }
    public void HandleRewardBasedVideoClosed(object sender, System.EventArgs args) //laduje nastepne rewardAd po zamknieciu poprzedniego
    {
        RequestReward();
    }




}
