using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestSystemLVL1 : MonoBehaviour
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
    private string Zadanie1 = ("Edit your friend's profile photo." );
    private string Zadanie2 = ("Create a banner for facebook for your friend.");
    private string Zadanie3 = ("Create a graphic for a brochure.");
    private string Zadanie4 = ("Create an avatar for a friend.");
    

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
        rnd1 = 1;
        switch (rnd1)
        {
            case 1:
                zadanie_1.text = "" + Zadanie1;
                Reward1.text = "20";
                Czas1.text = "30 min";
                break;
            
        }

    }
    public void Losowanie2()
    {
        rnd2 = 2;
        switch (rnd2)
        {
            case 2:
                zadanie_2.text = "" + Zadanie2;
                Reward2.text = "40";
                Czas2.text = "45 min";
                break;
        }
    }
    public void Losowanie3()
    {
        rnd3 = 3;
        switch (rnd3)
        {
            case 3:
                zadanie_3.text = "" + Zadanie3;
                Reward3.text = "50";
                Czas3.text = "60 min";
                break;
        }
    }
    public void Losowanie4()
    {
        rnd4 = 4;
        switch (rnd4)
        {
            case 4:
                zadanie_4.text = "" + Zadanie4;
                Reward4.text = "20";
                Czas4.text = "20 min";
                break;
            
        }

    }
    public void Claim1()
    {
        switch (rnd1)
        {
            case 1:
                ZmienneTag.reward = 20;
                ZmienneTag.time = 30;

                break;
           
        }
        questProgress.progressBar.minValue = ZmienneTag.time * (-1);
        ZmienneTag.isQuestTaken = 1;
    }
    public void Claim2()
    {
        switch (rnd2)
        {
            case 2:
                ZmienneTag.reward = 40;
                ZmienneTag.time = 45;
                break;
          
        }
        questProgress.progressBar.minValue = ZmienneTag.time * (-1);
        ZmienneTag.isQuestTaken = 1;
    }
    public void Claim3()
    {
        switch (rnd3)
        {
            case 3:
                ZmienneTag.reward = 50;
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
            case 4:
                ZmienneTag.reward = 20;
                ZmienneTag.time = 20;
                break;
           
        }
        questProgress.progressBar.minValue = ZmienneTag.time * (-1);
        ZmienneTag.isQuestTaken = 1;
    }


}

