using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCounter : MonoBehaviour {

    void Awake()
    {
        IncrementLaunchCount();
        Destroy(this);
    }

    void IncrementLaunchCount()
    {
        // check if the key exists.
        // if so, add to count
        // if not, first time launched, add key
        if (PlayerPrefs.HasKey("LaunchCount"))
        {
            // get the current count
            int lc = PlayerPrefs.GetInt("LaunchCount");
            // increment the count
            lc += 1;
            // set to PlayerPrefs
            PlayerPrefs.SetInt("LaunchCount", lc);
        }
        else
        {
            // if not, first time launched, add key
            PlayerPrefs.SetInt("LaunchCount", 1);
        }
    }
}
