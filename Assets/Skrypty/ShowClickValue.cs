using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowClickValue : MonoBehaviour {

    private void Start()
    {
        GetComponent<Text>().text = Mathf.Round(ZmienneTag.clickPower).ToString();
        Destroy(gameObject, 1.5f);
        
    }
}
