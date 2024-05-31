using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gameplay : MonoBehaviour {

    public Reklamy reklamy;
    public GameObject ZleceniaButton;
    public GameObject Cash;
    public Text Time;
    public SaveLoad saveLoad;
    public GameObject zlecenia;
    public GameObject clickPrefab;
    //public QuestSystemLVL1 questSystemLVL1;
    //public QuestSystemLVL2 questSystemLVL2;
    //public QuestSystemLVL3 questSystemLVL3;
    //public QuestSystemLVL4 questSystemLVL4;
    //public GameObject RenderWindow;
    public GameObject mailButton;
    public GameObject progerssWindow;
    public Reklamy ads;

    void Start ()
    {
        Input.simulateMouseWithTouches = true;
	}

    // Update is called once per frame
    void Update() {

        if (ZmienneTag.time != 0 && ZmienneTag.time > 0)
            Time.text = "" + Mathf.Round(ZmienneTag.time).ToString() + " min";
        else if (ZmienneTag.time <= 0)
            Time.text = "";


        if (ZmienneTag.isQuestTaken > 0)
        {
            mailButton.GetComponent<Button>().interactable = false;
            progerssWindow.SetActive(true);
        }

        if (ZmienneTag.completedQuests == 1)
        {
            ZmienneTag.LVL = 2;
            ZmienneTag.completedQuests = 0;
        }
        else if (ZmienneTag.completedQuests == 2)
        {
            ZmienneTag.LVL = 3;
            ZmienneTag.completedQuests = 0;
        }
        else if (ZmienneTag.completedQuests == 3)
        {
            ZmienneTag.LVL = 4;
            ZmienneTag.completedQuests = 0;
        }

        if (ZmienneTag.isQuestTaken > 0 && ZmienneTag.time <= 0) //when quest is over
        {
            System.Random random = new System.Random();
            ZmienneTag.completedQuests += 1;
            //ads.RequestInterstitial();
            ZmienneTag.Cash += ZmienneTag.reward;
            mailButton.GetComponent<Button>().interactable = true;
            progerssWindow.SetActive(false);
            switch (ZmienneTag.isQuestTaken) //depending of which quest was taken, generate new
            {
                case 1:
                    ZmienneTag.Quest1 = QuestSystem.GetQuest(random);
                    break;
                case 2:
                    ZmienneTag.Quest2 = QuestSystem.GetQuest(random);
                    break;
                case 3:
                    ZmienneTag.Quest3 = QuestSystem.GetQuest(random);
                    break;
                case 4:
                    ZmienneTag.Quest4 = QuestSystem.GetQuest(random);
                    break;
                case 5:
                    ZmienneTag.Quest5 = QuestSystem.GetQuest(random);
                    break;
                default:
                    break;
            }
            ZmienneTag.isQuestTaken = 0;
        }


    }
    public void Click()
    {
        
        if(ZmienneTag.isQuestTaken > 0)
        {        
            ZmienneTag.time += ZmienneTag.clickPower;
        }
            
    }
}
