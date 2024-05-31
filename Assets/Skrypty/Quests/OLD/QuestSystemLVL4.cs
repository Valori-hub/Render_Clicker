using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestSystemLVL4 : MonoBehaviour
{

    #region ZmienneText
    public Text zadanie_1;
    public Text zadanie_2;
    public Text zadanie_3;
    public Text zadanie_4;
    public Text Time;
    #endregion
    #region Zadania

    public int rnd1;
    public int rnd2;
    public int rnd3;
    public int rnd4;
    private string Zadanie1 = ("You have to montage wedding movie." + " Reward: 100$" + " Work Time: 120 min");
    private string Zadanie2 = ("Make streams highlights montage for Youtube channel." + " Reward: 90$" + " WorkTime: 100 min");
    private string Zadanie3 = ("Make presentation for a family celebration." + " Reward: 120$" + " WorkTime: 150 min");
    private string Zadanie4 = ("Make advertisement video." + " Reward: 70$" + " WorkTime: 80min");
    private string Zadanie5 = ("Create simple logo." + " Reward: 50$" + " WorkTime: 60min");
    private string Zadanie6 = ("Create banner for YouTube Channel." + " Reward: 35$" + " WorkTime: 40min");
    private string Zadanie7 = ("Create avatar for socials." + " Reward: 30$" + " WorkTime: 30min");
    private string Zadanie8 = ("Edit video for YouTube Channel." + " Reward: 75$" + " WorkTime: 120min");
    private string Zadanie9 = ("Make promotion graphic for local event." + " Reward: 40$" + " WorkTime: 60min");
    private string Zadanie10 = ("Create intro for YouTube Channel." + " Reward: 50$" + " WorkTime: 80min");
    private string Zadanie11 = ("Create some simple animations." + " Reward: 40$" + " WorkTime: 70min");
    private string Zadanie12 = ("Add subtitles to video." + " Reward: 30$" + " WorkTime: 60min");
    private string Zadanie13 = ("Edit my holidays photos." + " Reward: 20$" + " WorkTime: 40min");
    private string Zadanie14 = ("Make infographic for FB fanpage." + " Reward: 40$" + " WorkTime: 80min");
    private string Zadanie15 = ("Design simple buttons for small game." + " Reward: 70$" + " WorkTime: 180min");
    private string Zadanie16 = ("Make boring video interesing." + " Reward: 60$" + " WorkTime: 90min");

    #endregion
    #region ZmienneObject
    public GameObject claim_1;
    public GameObject claim_2;
    public GameObject claim_3;
    public GameObject claim_4;

    public GameObject[] AllGO;
    public QuestProgress questProgress;
    #endregion

    private void Awake()
    {
        AllGO = Resources.FindObjectsOfTypeAll<GameObject>();
        foreach (GameObject GO in AllGO)
        {
            if (GO.name == "Claim1")
                claim_1 = GO;
            if (GO.name == "Claim2")
                claim_2 = GO;
            if (GO.name == "Claim3")
                claim_3 = GO;
            if (GO.name == "Claim4")
                claim_4 = GO;
            if (GO.name == "Scripts")
                questProgress = GO.GetComponent<QuestProgress>();

            if (GO.name == "Text1")
                zadanie_1 = GO.GetComponent<Text>();
            if (GO.name == "Text2")
                zadanie_2 = GO.GetComponent<Text>();
            if (GO.name == "Text3")
                zadanie_3 = GO.GetComponent<Text>();
            if (GO.name == "Text4")
                zadanie_4 = GO.GetComponent<Text>();
        }
        claim_1.GetComponent<Button>().onClick.AddListener(Claim1);
        claim_2.GetComponent<Button>().onClick.AddListener(Claim2);
        claim_3.GetComponent<Button>().onClick.AddListener(Claim3);
        claim_4.GetComponent<Button>().onClick.AddListener(Claim4);
    }
    private void Start()
    {
        Losowanie1();
        Losowanie2();
        Losowanie3();
        Losowanie4();
    }
    private void Update()
    {
        //if (claim_1.GetComponent<Button>().interactable == false && claim_2.GetComponent<Button>().interactable == false &&
        //    claim_3.GetComponent<Button>().interactable == false && claim_4.GetComponent<Button>().interactable == false)
        //{
        //    Losowanie1();
        //    Losowanie2();
        //    Losowanie3();
        //    Losowanie4();
        //    claim_1.GetComponent<Button>().interactable = true;
        //    claim_2.GetComponent<Button>().interactable = true;
        //    claim_3.GetComponent<Button>().interactable = true;
        //    claim_4.GetComponent<Button>().interactable = true;
        //}
        //if (PlayerPrefs.HasKey("isTaken1") || PlayerPrefs.HasKey("isTaken2") ||
        //    PlayerPrefs.HasKey("isTaken3") || PlayerPrefs.HasKey("isTaken4"))
        //{
        //    if (PlayerPrefs.GetInt("isTaken1") == 1)
        //        claim_1.GetComponent<Button>().interactable = false;
        //    else
        //        claim_1.GetComponent<Button>().interactable = true;
        //    if (PlayerPrefs.GetInt("isTaken2") == 1)
        //        claim_2.GetComponent<Button>().interactable = false;
        //    else
        //        claim_2.GetComponent<Button>().interactable = true;
        //    if (PlayerPrefs.GetInt("isTaken3") == 1)
        //        claim_3.GetComponent<Button>().interactable = false;
        //    else
        //        claim_3.GetComponent<Button>().interactable = true;
        //    if (PlayerPrefs.GetInt("isTaken4") == 1)
        //        claim_4.GetComponent<Button>().interactable = false;
        //    else
        //        claim_4.GetComponent<Button>().interactable = true;
        //}
        //else
        //{
        //    PlayerPrefs.SetInt("isTaken1", 0);
        //    PlayerPrefs.SetInt("isTaken2", 0);
        //    PlayerPrefs.SetInt("isTaken3", 0);
        //    PlayerPrefs.SetInt("isTaken4", 0);
        //}

    }
    public void Losowanie1()
    {
        rnd1 = Random.Range(1, 4);
        switch (rnd1)
        {
            case 1:
                zadanie_1.text = "" + Zadanie1;
                break;
            case 2:
                zadanie_1.text = "" + Zadanie2;
                break;
            case 3:
                zadanie_1.text = "" + Zadanie3;
                break;
            case 4:
                zadanie_1.text = "" + Zadanie4;
                break;
        }

    }
    public void Losowanie2()
    {
        rnd2 = Random.Range(5, 8);
        switch (rnd2)
        {

            case 5:
                zadanie_2.text = "" + Zadanie5;
                break;
            case 6:
                zadanie_2.text = "" + Zadanie6;
                break;
            case 7:
                zadanie_2.text = "" + Zadanie7;
                break;
            case 8:
                zadanie_2.text = "" + Zadanie8;
                break;
        }
    }
    public void Losowanie3()
    {
        rnd3 = Random.Range(9, 12);
        switch (rnd3)
        {
            case 9:
                zadanie_3.text = "" + Zadanie9;
                break;
            case 10:
                zadanie_3.text = "" + Zadanie10;
                break;
            case 11:
                zadanie_3.text = "" + Zadanie11;
                break;
            case 12:
                zadanie_3.text = "" + Zadanie12;
                break;
        }
    }
    public void Losowanie4()
    {
        rnd4 = Random.Range(13, 16);
        switch (rnd4)
        {
            case 13:
                zadanie_4.text = "" + Zadanie13;
                break;
            case 14:
                zadanie_4.text = "" + Zadanie14;
                break;
            case 15:
                zadanie_4.text = "" + Zadanie15;
                break;
            case 16:
                zadanie_4.text = "" + Zadanie16;
                break;
        }

    }
    public void Claim1()
    {
        switch (rnd1)
        {
            case 1:
                ZmienneTag.reward = 100;
                ZmienneTag.time = 120;

                break;
            case 2:
                ZmienneTag.reward = 100;
                ZmienneTag.time = 100;

                break;
            case 3:
                ZmienneTag.reward = 150;
                ZmienneTag.time = 150;

                break;
            case 4:
                ZmienneTag.reward = 70;
                ZmienneTag.time = 80;

                break;
        }
        questProgress.progressBar.minValue = ZmienneTag.time * (-1);
        ZmienneTag.isQuestTaken = 1;
    }
    public void Claim2()
    {
        switch (rnd2)
        {
            case 5:
                ZmienneTag.reward = 50;
                ZmienneTag.time = 60;
                break;
            case 6:
                ZmienneTag.reward = 35;
                ZmienneTag.time = 40;
                break;
            case 7:
                ZmienneTag.reward = 30;
                ZmienneTag.time = 30;
                break;
            case 8:
                ZmienneTag.reward = 75;
                ZmienneTag.time = 120;
                break;
        }
        questProgress.progressBar.minValue = ZmienneTag.time * (-1);
        ZmienneTag.isQuestTaken = 1;
    }
    public void Claim3()
    {
        switch (rnd3)
        {
            case 9:
                ZmienneTag.reward = 40;
                ZmienneTag.time = 60;
                break;
            case 10:
                ZmienneTag.reward = 50;
                ZmienneTag.time = 80;
                break;
            case 11:
                ZmienneTag.reward = 40;
                ZmienneTag.time = 70;
                break;
            case 12:
                ZmienneTag.reward = 30;
                ZmienneTag.time = 60;
                break;
        }
        questProgress.progressBar.minValue = ZmienneTag.time * (-1);
        ZmienneTag.isQuestTaken = 1;
    }
    public void Claim4()
    {
        switch (rnd4)
        {
            case 13:
                ZmienneTag.reward = 20;
                ZmienneTag.time = 40;
                break;
            case 14:
                ZmienneTag.reward = 40;
                ZmienneTag.time = 80;
                break;
            case 15:
                ZmienneTag.reward = 70;
                ZmienneTag.time = 180;
                break;
            case 16:
                ZmienneTag.reward = 60;
                ZmienneTag.time = 90;
                break;
        }
        questProgress.progressBar.minValue = ZmienneTag.time * (-1);
        ZmienneTag.isQuestTaken = 1;
    }

}

