using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SilnikFix : MonoBehaviour {

    public GameObject clickPrefab;

    // Update is called once per frame
    //void Update()
    //{
    //    if (ZmienneTag.isQuestTaken == 1)
    //    {
    //        if (Input.touchCount > 0)
    //        {
    //            Touch touch = Input.GetTouch(0);
    //            if (touch.phase == TouchPhase.Began)
    //            {
    //                Instantiate(clickPrefab, touch.position, Quaternion.identity, gameObject.transform).AddComponent<ShowClickValue>();
    //            }

    //        }
    //    }
    //}
    public void Click()
    {

        if (ZmienneTag.isQuestTaken == 1)
        {
            Instantiate(clickPrefab, Input.mousePosition, Quaternion.identity, gameObject.transform).AddComponent<ShowClickValue>();
        }

    }
}
