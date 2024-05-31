using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestProgress : MonoBehaviour {
    public Slider progressBar;
	// Use this for initialization
	void Start () {
        progressBar.value = progressBar.minValue;
        progressBar.maxValue = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (ZmienneTag.isQuestTaken == 0)
        {
            progressBar.value = progressBar.minValue;
        }
        else
        {
            progressBar.value = ZmienneTag.time * (-1);
        }
    }
}
