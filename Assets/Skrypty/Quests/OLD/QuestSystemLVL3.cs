using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestSystemLVL3 : MonoBehaviour
{

    #region ZmienneText
    public Text zadanie_1;
    public Text zadanie_2;
    public Text zadanie_3;
    public Text zadanie_4;
    public Text Time;


    public Text Reward1;
    public Text Reward2;
    public Text Reward3;
    public Text Reward4;

    public Text Czas1;
    public Text Czas2;
    public Text Czas3;
    public Text Czas4;

    #endregion
    #region Zadania

    public int rnd1;
    public int rnd2;
    public int rnd3;
    public int rnd4;
    private string Zadanie1 = ("test1");
    private string Zadanie2 = ("test2");
    private string Zadanie3 = ("test3");
    private string Zadanie4 = ("test4");
    private string Zadanie5 = ("test5");
    private string Zadanie6 = ("test6");
    private string Zadanie7 = ("test7");
    private string Zadanie8 = ("test8");
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

            if(GO.name == "Text1")
                zadanie_1 = GO.GetComponent<Text>();
            if (GO.name == "Text2")
                zadanie_2 = GO.GetComponent<Text>();
            if (GO.name == "Text3")
                zadanie_3 = GO.GetComponent<Text>();
            if (GO.name == "Text4")
                zadanie_4 = GO.GetComponent<Text>();

            if (GO.name == "pieniadze1")
                Reward1 = GO.GetComponent<Text>();
            if (GO.name == "pieniadze2")
                Reward2 = GO.GetComponent<Text>();
            if (GO.name == "pieniadze3")
                Reward3 = GO.GetComponent<Text>();
            if (GO.name == "pieniadze4")
                Reward4 = GO.GetComponent<Text>();

            if (GO.name == "czas1")
                Czas1 = GO.GetComponent<Text>();
            if (GO.name == "czas2")
                Czas2 = GO.GetComponent<Text>();
            if (GO.name == "czas3")
                Czas3 = GO.GetComponent<Text>();
            if (GO.name == "czas4")
                Czas4 = GO.GetComponent<Text>();
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
        rnd1 = Random.Range(1, 3);
        switch (rnd1)
        {
            case 1:
                zadanie_1.text = "" + Zadanie1;
                Reward1.text = "50";
                Czas1.text = "60 min";
                break;
            case 2:
                zadanie_1.text = "" + Zadanie2;
                Reward1.text = "80";
                Czas1.text = "100 min";
                break;
            case 3:
                zadanie_1.text = "" + Zadanie3;
                Reward1.text = "30";
                Czas1.text = "20 min";
                break;       
        }

    }
    public void Losowanie2()
    {
        rnd2 = Random.Range(4, 6);
        switch (rnd2)
        {

            case 4:
                zadanie_2.text = "" + Zadanie4;
                Reward2.text = "40";
                Czas2.text = "50 min";
                break;
            case 5:
                zadanie_2.text = "" + Zadanie5;
                Reward2.text = "80";
                Czas2.text = "60 min";
                break;
            case 6:
                zadanie_2.text = "" + Zadanie6;
                Reward2.text = "100";
                Czas2.text = "80 min";
                break;
        }
    }
    public void Losowanie3()
    {
        rnd3 = Random.Range(7, 9);
        switch (rnd3)
        {
            case 7:
                zadanie_3.text = "" + Zadanie7;
                Reward3.text = "50";
                Czas3.text = "30 min";
                break;
            case 8:
                zadanie_3.text = "" + Zadanie8;
                Reward3.text = "85";
                Czas3.text = "70 min";
                break;
            case 9:
                zadanie_3.text = "" + Zadanie9;
                Reward3.text = "40";
                Czas3.text = "60 min";
                break;
        }
    }
    public void Losowanie4()
    {
        rnd4 = Random.Range(10, 12);
        switch (rnd4)
        {
            case 10:
                zadanie_4.text = "" + Zadanie10;
                Reward4.text = "50";
                Czas4.text = "60 min";
                break;
            case 11:
                zadanie_4.text = "" + Zadanie11;
                Reward4.text = "40";
                Czas4.text = "70 min";
                break;
            case 12:
                zadanie_4.text = "" + Zadanie12;
                Reward4.text = "50";
                Czas4.text = "60 min";
                break;
        }

    }
    public void Claim1()
    {
        switch (rnd1)
        {
            case 1:
                ZmienneTag.reward = 50;
                ZmienneTag.time = 60;

                break;
            case 2:
                ZmienneTag.reward = 80;
                ZmienneTag.time = 100;

                break;
            case 3:
                ZmienneTag.reward = 150;
                ZmienneTag.time = 150;
                break;
        }
        questProgress.progressBar.minValue = ZmienneTag.time * (-1);
        ZmienneTag.isQuestTaken = 1;
    }
    public void Claim2()
    {
        switch (rnd2)
        {
            case 4:
                ZmienneTag.reward = 40;
                ZmienneTag.time = 50;
                break;
            case 5:
                ZmienneTag.reward = 80;
                ZmienneTag.time = 60;
                break;
            case 6:
                ZmienneTag.reward = 30;
                ZmienneTag.time = 30;
                break;
        }
        questProgress.progressBar.minValue = ZmienneTag.time * (-1);
        ZmienneTag.isQuestTaken = 1;
    }
    public void Claim3()
    {
        switch (rnd3)
        {
            case 7:
                ZmienneTag.reward = 50;
                ZmienneTag.time = 30;
                break;
            case 8:
                ZmienneTag.reward = 85;
                ZmienneTag.time = 70;
                break;
            case 9:
                ZmienneTag.reward = 40;
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
            case 10:
                ZmienneTag.reward = 50;
                ZmienneTag.time = 60;
                break;
            case 11:
                ZmienneTag.reward = 40;
                ZmienneTag.time = 70;
                break;
            case 12:
                ZmienneTag.reward = 50;
                ZmienneTag.time = 60;
                break;
        }
        questProgress.progressBar.minValue = ZmienneTag.time * (-1);
        ZmienneTag.isQuestTaken = 1;
    }

}

