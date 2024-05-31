using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PreloadSelectRes : MonoBehaviour {

    public float x;
    public float y;
	// Use this for initialization
	void Start () {
        x = Screen.width;
        y = Screen.height;

        if (x == 720 && y == 1280)
            SceneManager.LoadScene("720x1280");
        if (x == 1080 && y == 1920)
            SceneManager.LoadScene("1080x1920");
        if (x == 540 && y == 960)
            SceneManager.LoadScene("540x960");
        if (x == 750 && y == 1334)
            SceneManager.LoadScene("750x1334");
        if (x == 480 && y == 800)
            SceneManager.LoadScene("480x800");
        if (x == 1440 && y == 2560)
            SceneManager.LoadScene("1440x2560");
        if (x == 1440 && y == 2960)
            SceneManager.LoadScene("1440x2960");
        if (x == 640 && y == 1136)
            SceneManager.LoadScene("640x1136");
        if (x == 480 && y == 854)
            SceneManager.LoadScene("480x854");
        if (x == 240 && y == 320)
            SceneManager.LoadScene("240x320");
        if (x == 1125 && y == 2436)
            SceneManager.LoadScene("1125x2436");
    }
	
}
