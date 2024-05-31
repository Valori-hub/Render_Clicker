using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestSystemLVL2 : MonoBehaviour
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
    private string Zadanie1 = ("You have to montage wedding movie.");
    private string Zadanie2 = ("Make streams highlights montage for unpopular Youtube channel.");
    private string Zadanie3 = ("Make presentation for a family celebration.");
    private string Zadanie4 = ("Make advertisement video.");
    private string Zadanie5 = ("Create simple logo.");
    private string Zadanie6 = ("Create banner for unpopular YouTube Channel.");
    private string Zadanie7 = ("Create avatar for socials.");
    private string Zadanie8 = ("Edit video for YouTube Channel.");
    
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
        rnd1 = Random.Range(1, 2);
        switch (rnd1)
        {
            case 1:
                zadanie_1.text = "" + Zadanie1;
                Reward1.text = "100";
                Czas1.text = "120 min";
                break;
            case 2:
                zadanie_1.text = "" + Zadanie2;
                Reward1.text = "90";
                Czas1.text = "100 min";
                break;

        }

    }
    public void Losowanie2()
    {
        rnd2 = Random.Range(3, 4);
        switch (rnd2)
        {

            case 3:
                zadanie_2.text = "" + Zadanie3;
                Reward2.text = "120";
                Czas2.text = "150 min";
                break;
            case 4:
                zadanie_2.text = "" + Zadanie4;
                Reward2.text = "70";
                Czas2.text = "80 min";
                break;
          
        }
    }
    public void Losowanie3()
    {
        rnd3 = Random.Range(9, 10);
        switch (rnd3)
        {
            case 9:
                zadanie_3.text = "" + Zadanie5;
                Reward3.text = "50";
                Czas3.text = "60 min";
                break;
            case 10:
                zadanie_3.text = "" + Zadanie6;
                Reward3.text = "35";
                Czas3.text = "40 min";
                break;
        }
    }
    public void Losowanie4()
    {
        rnd4 = Random.Range(13, 14);
        switch (rnd4)
        {
            case 13:
                zadanie_4.text = "" + Zadanie7;
                Reward4.text = "35";
                Czas4.text = "30 min";
                break;
            case 14:
                zadanie_4.text = "" + Zadanie8;
                Reward4.text = "75";
                Czas4.text = "120 min";
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
                ZmienneTag.reward = 90;
                ZmienneTag.time = 100;
                break;
            
        }
        questProgress.progressBar.minValue = ZmienneTag.time * (-1);
        ZmienneTag.isQuestTaken = 1;
    }
    public void Claim2()
    {
        switch (rnd2)
        {
            case 3:
                ZmienneTag.reward = 120;
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
    public void Claim3()
    {
        switch (rnd3)
        {
            case 9:
                ZmienneTag.reward = 50;
                ZmienneTag.time = 60;
                break;
            case 10:
                ZmienneTag.reward = 35;
                ZmienneTag.time = 40;
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
                ZmienneTag.reward = 35;
                ZmienneTag.time = 30;
                break;
            case 14:
                ZmienneTag.reward = 75;
                ZmienneTag.time = 120;
                break;
        }
        questProgress.progressBar.minValue = ZmienneTag.time * (-1);
        ZmienneTag.isQuestTaken = 1;
    }

}

