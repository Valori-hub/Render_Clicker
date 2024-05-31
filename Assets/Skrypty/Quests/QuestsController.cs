using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestsController : MonoBehaviour
{
    public GameObject panel;
    public GameObject mailPanel;

    private void Update()
    {
        if (this.name!="backButton" || this.name!="AcceptButton")
        {
            string txt = "TEST";

            switch (this.name)
            {
                case "Quest 1":
                    txt = ZmienneTag.Quest1["title"];
                    break;
                case "Quest 2":
                    txt = ZmienneTag.Quest2["title"];
                    break;
                case "Quest 3":
                    txt = ZmienneTag.Quest3["title"];
                    break;
                case "Quest 4":
                    txt = ZmienneTag.Quest4["title"];
                    break;
                case "Quest 5":
                    txt = ZmienneTag.Quest5["title"];
                    break;
                default:
                    break;
            }

            this.GetComponent<Text>().text = txt;
        }

    }

    public void QuestPanel()
    {
        panel.SetActive(true);
        Debug.Log(this.name);
        switch (this.name)
        {
            case "Quest 1":
                panel.transform.GetChild(0).GetComponent<Text>().text = ZmienneTag.Quest1["time"]+" min";
                panel.transform.GetChild(1).GetComponent<Text>().text = ZmienneTag.Quest1["salary"];
                panel.transform.GetChild(3).GetComponent<Text>().text = ZmienneTag.Quest1["title"];
                panel.transform.GetChild(4).GetComponent<Text>().text = ZmienneTag.Quest1["message"]+"\n"+ ZmienneTag.Quest1["name"];
                panel.transform.GetChild(6).name = "Quest 1";
                break;
            case "Quest 2":
                panel.transform.GetChild(0).GetComponent<Text>().text = ZmienneTag.Quest2["time"] + " min";
                panel.transform.GetChild(1).GetComponent<Text>().text = ZmienneTag.Quest2["salary"];
                panel.transform.GetChild(3).GetComponent<Text>().text = ZmienneTag.Quest2["title"];
                panel.transform.GetChild(4).GetComponent<Text>().text = ZmienneTag.Quest2["message"] + "\n" + ZmienneTag.Quest2["name"];
                panel.transform.GetChild(6).name = "Quest 2";
                break;
            case "Quest 3":
                panel.transform.GetChild(0).GetComponent<Text>().text = ZmienneTag.Quest3["time"] + " min";
                panel.transform.GetChild(1).GetComponent<Text>().text = ZmienneTag.Quest3["salary"];
                panel.transform.GetChild(3).GetComponent<Text>().text = ZmienneTag.Quest3["title"];
                panel.transform.GetChild(4).GetComponent<Text>().text = ZmienneTag.Quest3["message"] + "\n" + ZmienneTag.Quest3["name"];
                panel.transform.GetChild(6).name = "Quest 3";
                break;
            case "Quest 4":
                panel.transform.GetChild(0).GetComponent<Text>().text = ZmienneTag.Quest4["time"] + " min";
                panel.transform.GetChild(1).GetComponent<Text>().text = ZmienneTag.Quest4["salary"];
                panel.transform.GetChild(3).GetComponent<Text>().text = ZmienneTag.Quest4["title"];
                panel.transform.GetChild(4).GetComponent<Text>().text = ZmienneTag.Quest4["message"] + "\n" + ZmienneTag.Quest4["name"];
                panel.transform.GetChild(6).name = "Quest 4";
                break;
            case "Quest 5":
                panel.transform.GetChild(0).GetComponent<Text>().text = ZmienneTag.Quest5["time"] + " min";
                panel.transform.GetChild(1).GetComponent<Text>().text = ZmienneTag.Quest5["salary"];
                panel.transform.GetChild(3).GetComponent<Text>().text = ZmienneTag.Quest5["title"];
                panel.transform.GetChild(4).GetComponent<Text>().text = ZmienneTag.Quest5["message"] + "\n" + ZmienneTag.Quest5["name"];
                panel.transform.GetChild(6).name = "Quest 5";
                break;
            default:
                break;
        }
    }
    public void CloseQuestPanel()
    {
        panel.SetActive(false); //dont work, idk why
    }
    public void ClaimQuest()
    {
        string name = GameObject.FindGameObjectWithTag("questNumber").name;
        switch (name)
        {
            case "Quest 1":
                ZmienneTag.isQuestTaken = 1;
                ZmienneTag.reward = int.Parse(ZmienneTag.Quest1["salary"]);
                ZmienneTag.time = int.Parse(ZmienneTag.Quest1["time"]);
                break;
            case "Quest 2":
                ZmienneTag.isQuestTaken = 2;
                ZmienneTag.reward = int.Parse(ZmienneTag.Quest2["salary"]);
                ZmienneTag.time = int.Parse(ZmienneTag.Quest2["time"]);
                break;
            case "Quest 3":
                ZmienneTag.isQuestTaken = 3;
                ZmienneTag.reward = int.Parse(ZmienneTag.Quest3["salary"]);
                ZmienneTag.time = int.Parse(ZmienneTag.Quest3["time"]);
                break;
            case "Quest 4":
                ZmienneTag.isQuestTaken = 4;
                ZmienneTag.reward = int.Parse(ZmienneTag.Quest4["salary"]);
                ZmienneTag.time = int.Parse(ZmienneTag.Quest4["time"]);
                break;
            case "Quest 5":
                ZmienneTag.isQuestTaken = 5;
                ZmienneTag.reward = int.Parse(ZmienneTag.Quest5["salary"]);
                ZmienneTag.time = int.Parse(ZmienneTag.Quest5["time"]);
                break;
            default:
                break;
        }
        panel.SetActive(false);
        mailPanel.SetActive(false);
        Debug.Log(ZmienneTag.isQuestTaken);
        Debug.Log(ZmienneTag.time);
        Debug.Log(ZmienneTag.reward);
    }
}
