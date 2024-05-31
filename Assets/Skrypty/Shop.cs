using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop : MonoBehaviour {

    public SaveLoad saveLoad;
    public Audio SFXaudio;

    //public GameObject[] CPU = new GameObject[6];
    //public GameObject[] GPU = new GameObject[6];
    //public GameObject[] RAM = new GameObject[6];
    //public GameObject[] DISK = new GameObject[6];

    public Text cash;
    public Text GPUlvl;
    public Text CPUlvl;
    public Text RAMlvl;
    public Text DISKlvl;

    public Text GPUupg;
    public Text CPUupg;
    public Text RAMupg;
    public Text DISKupg;

    public Slider GPUslider;
    public Slider CPUslider;
    public Slider RAMslider;
    public Slider DISKslider;

    private void Start()
    {
        saveLoad.Load();
    }
    private void Update()
    {
        Money();
        GPUlvl.text = ZmienneTag.GPUlvl.ToString() + "/5";
        CPUlvl.text = ZmienneTag.CPUlvl.ToString() + "/5";
        RAMlvl.text = ZmienneTag.RAMlvl.ToString() + "/5";
        DISKlvl.text = ZmienneTag.DISKlvl.ToString() + "/5";

        GPUslider.value = ZmienneTag.GPUlvl;
        CPUslider.value = ZmienneTag.CPUlvl;
        RAMslider.value = ZmienneTag.RAMlvl;
        DISKslider.value = ZmienneTag.DISKlvl;

        switch (ZmienneTag.GPUlvl)
        {
            case 0:
                GPUupg.text = "100$";
                //GPU[0].SetActive(false);
                //GPU[1].SetActive(true);
                break;
            case 1:
                GPUupg.text = "200$";
                //GPU[1].SetActive(false);
                //GPU[2].SetActive(true);
                break;
            case 2:
                GPUupg.text = "350$";
                //GPU[2].SetActive(false);
                //GPU[3].SetActive(true);
                break;
            case 3:
                GPUupg.text = "700$";
                //GPU[3].SetActive(false);
                //GPU[4].SetActive(true);
                break;
            case 4:
                GPUupg.text = "1500$";
                //GPU[4].SetActive(false);
                //GPU[5].SetActive(true);
                break;
            case 5:
                GPUupg.text = "More levels coming soon!";
                break;
            default:
                break;
        }
        switch (ZmienneTag.CPUlvl)
        {
            case 0:
                CPUupg.text = "100$";
                //CPU[0].SetActive(false);
                //CPU[1].SetActive(true);
                break;
            case 1:
                CPUupg.text = "200$";
                //CPU[1].SetActive(false);
                //CPU[2].SetActive(true);
                break;
            case 2:
                CPUupg.text = "350$";
                //CPU[2].SetActive(false);
                //CPU[3].SetActive(true);
                break;
            case 3:
                CPUupg.text = "700$";
                //CPU[3].SetActive(false);
                //CPU[4].SetActive(true);
                break;
            case 4:
                CPUupg.text = "1000$";
                //CPU[4].SetActive(false);
                //CPU[5].SetActive(true);
                break;
            case 5:
                CPUupg.text = "More levels coming soon!";
                break;
            default:
                break;
        }
        switch (ZmienneTag.RAMlvl)
        {
            case 0:
                RAMupg.text = "50$";
                //RAM[0].SetActive(false);
                //RAM[1].SetActive(true);
                break;
            case 1:
                RAMupg.text = "100$";
                //RAM[1].SetActive(false);
                //RAM[2].SetActive(true);
                break;
            case 2:
                RAMupg.text = "250$";
                //RAM[2].SetActive(false);
                //RAM[3].SetActive(true);
                break;
            case 3:
                RAMupg.text = "400$";
                //RAM[3].SetActive(false);
                //RAM[4].SetActive(true);
                break;
            case 4:
                RAMupg.text = "550$";
                //RAM[4].SetActive(false);
                //RAM[5].SetActive(true);
                break;
            case 5:
                RAMupg.text = "More levels coming soon!";
                break;
            default:
                break;
        }
        switch (ZmienneTag.DISKlvl)
        {
            case 0:
                DISKupg.text = "100$";
                //DISK[0].SetActive(false);
                //DISK[1].SetActive(true);
                break;
            case 1:
                DISKupg.text = "150$";
                //DISK[1].SetActive(false);
                //DISK[2].SetActive(true);
                break;
            case 2:
                DISKupg.text = "300$";
                //DISK[2].SetActive(false);
                //DISK[3].SetActive(true);
                break;
            case 3:
                DISKupg.text = "450$";
                //DISK[3].SetActive(false);
                //DISK[4].SetActive(true);
                break;
            case 4:
                DISKupg.text = "600$";
                //DISK[4].SetActive(false);
                //DISK[5].SetActive(true);
                break;
            case 5:
                DISKupg.text = "More levels coming soon!";
                break;
            default:
                break;
        }
    }

    public void GPUup()
    {
        switch (ZmienneTag.GPUlvl)
        {
            case 0:
                if (ZmienneTag.Cash >= 100)
                {
                    SFXaudio.Buy();
                    ZmienneTag.GPUlvl = 1;
                    ZmienneTag.Cash -= 100;
                    ZmienneTag.clickPower -= 0.15f;
                    //GPU[0].SetActive(false);
                    //GPU[1].SetActive(true);
                    PlayerPrefs.SetInt("GPUlvl", ZmienneTag.GPUlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
                //else
                   // SFXaudio.Button();

                break;
            case 1:
                if (ZmienneTag.Cash >= 200)
                {
                    SFXaudio.Buy();
                    ZmienneTag.GPUlvl = 2;
                    ZmienneTag.Cash -= 200;
                    ZmienneTag.clickPower -= 0.25f;
                    //GPU[1].SetActive(false);
                    //GPU[2].SetActive(true);
                    PlayerPrefs.SetInt("GPUlvl", ZmienneTag.GPUlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
               // else
                  //  SFXaudio.Button();
                break;
            case 2:
                if (ZmienneTag.Cash >= 350)
                {
                    SFXaudio.Buy();
                    ZmienneTag.GPUlvl = 3;
                    ZmienneTag.Cash -= 350;
                    ZmienneTag.clickPower -= 0.35f;
                    //GPU[2].SetActive(false);
                    //GPU[3].SetActive(true);
                    PlayerPrefs.SetInt("GPUlvl", ZmienneTag.GPUlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
               // else
               //     SFXaudio.Button();
                break;
            case 3:
                if (ZmienneTag.Cash >= 700)
                {
                    SFXaudio.Buy();
                    ZmienneTag.GPUlvl = 4;
                    ZmienneTag.Cash -= 700;
                    ZmienneTag.clickPower -= 0.45f;
                    //GPU[3].SetActive(false);
                    //GPU[4].SetActive(true);
                    PlayerPrefs.SetInt("GPUlvl", ZmienneTag.GPUlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
                //else
                  //  SFXaudio.Button();
                break;
            case 4:
                if (ZmienneTag.Cash >= 1500)
                {
                    SFXaudio.Buy();
                    ZmienneTag.GPUlvl = 5;
                    ZmienneTag.Cash -= 1500;
                    ZmienneTag.clickPower -= 0.5f;
                    //GPU[4].SetActive(false);
                    //GPU[5].SetActive(true);
                    PlayerPrefs.SetInt("GPUlvl", ZmienneTag.GPUlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
               // else
                 //   SFXaudio.Button();
                break;
            case 5:
                //coming soon
                break;
            default:
                break;
        }
    }
    public void CPUup()
    {
        switch (ZmienneTag.CPUlvl)
        {
            case 0:
                if (ZmienneTag.Cash >= 100)
                {
                    SFXaudio.Buy();
                    ZmienneTag.CPUlvl = 1;
                    ZmienneTag.Cash -= 100;
                    ZmienneTag.clickPower -= 0.1f;
                    //CPU[0].SetActive(false);
                    //CPU[1].SetActive(true);
                    PlayerPrefs.SetInt("CPUlvl", ZmienneTag.CPUlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
                //else
                  //  SFXaudio.Button();

                break;
            case 1:
                if (ZmienneTag.Cash >= 200)
                {
                    SFXaudio.Buy();
                    ZmienneTag.CPUlvl = 2;
                    ZmienneTag.Cash -= 200;
                    ZmienneTag.clickPower -= 0.2f;
                    //CPU[1].SetActive(false);
                    //CPU[2].SetActive(true);
                    PlayerPrefs.SetInt("CPUlvl", ZmienneTag.CPUlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
               // else
                  //  SFXaudio.Button();
                break;
            case 2:
                if (ZmienneTag.Cash >= 350)
                {
                    SFXaudio.Buy();
                    ZmienneTag.CPUlvl = 3;
                    ZmienneTag.Cash -= 350;
                    ZmienneTag.clickPower -= 0.25f;
                    //CPU[2].SetActive(false);
                    //CPU[3].SetActive(true);
                    PlayerPrefs.SetInt("CPUlvl", ZmienneTag.CPUlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
               // else
                  //  SFXaudio.Button();
                break;
            case 3:
                if (ZmienneTag.Cash >= 700)
                {
                    SFXaudio.Buy();
                    ZmienneTag.CPUlvl = 4;
                    ZmienneTag.Cash -= 700;
                    ZmienneTag.clickPower -= 0.3f;
                    //CPU[3].SetActive(false);
                    //CPU[4].SetActive(true);
                    PlayerPrefs.SetInt("CPUlvl", ZmienneTag.CPUlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
                //else
                  //  SFXaudio.Button();
                break;
            case 4:
                if (ZmienneTag.Cash >= 1500)
                {
                    SFXaudio.Buy();
                    ZmienneTag.CPUlvl = 5;
                    ZmienneTag.Cash -= 1000;
                    ZmienneTag.clickPower -= 0.35f;
                    //CPU[4].SetActive(false);
                    //CPU[5].SetActive(true);
                    PlayerPrefs.SetInt("CPUlvl", ZmienneTag.CPUlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
               // else
                  //  SFXaudio.Button();
                break;
            case 5:
                //coming soon
                break;
            default:
                break;
        }
    }
    public void RAMup()
    {
        switch (ZmienneTag.RAMlvl)
        {
            case 0:
                if (ZmienneTag.Cash >= 100)
                {
                    SFXaudio.Buy();
                    ZmienneTag.RAMlvl = 1;
                    ZmienneTag.Cash -= 50;
                    ZmienneTag.clickPower -= 0.1f;
                    //RAM[0].SetActive(false);
                    //RAM[1].SetActive(true);
                    PlayerPrefs.SetInt("RAMlvl", ZmienneTag.RAMlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
                //else
                   // SFXaudio.Button();

                break;
            case 1:
                if (ZmienneTag.Cash >= 200)
                {
                    SFXaudio.Buy();
                    ZmienneTag.RAMlvl = 2;
                    ZmienneTag.Cash -= 100;
                    ZmienneTag.clickPower -= 0.1f;
                    //RAM[1].SetActive(false);
                    //RAM[2].SetActive(true);
                    PlayerPrefs.SetInt("RAMlvl", ZmienneTag.RAMlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
               // else
                    //SFXaudio.Button();
                break;
            case 2:
                if (ZmienneTag.Cash >= 350)
                {
                    SFXaudio.Buy();
                    ZmienneTag.RAMlvl = 3;
                    ZmienneTag.Cash -= 250;
                    ZmienneTag.clickPower -= 0.1f;
                    //RAM[2].SetActive(false);
                    //RAM[3].SetActive(true);
                    PlayerPrefs.SetInt("RAMlvl", ZmienneTag.RAMlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
                //else
                    //SFXaudio.Button();
                break;
            case 3:
                if (ZmienneTag.Cash >= 700)
                {
                    SFXaudio.Buy();
                    ZmienneTag.RAMlvl = 4;
                    ZmienneTag.Cash -= 400;
                    ZmienneTag.clickPower -= 0.1f;
                    //RAM[3].SetActive(false);
                    //RAM[4].SetActive(true);
                    PlayerPrefs.SetInt("RAMlvl", ZmienneTag.RAMlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
                else
                    SFXaudio.Button();
                break;
            case 4:
                if (ZmienneTag.Cash >= 1500)
                {
                    SFXaudio.Buy();
                    ZmienneTag.RAMlvl = 5;
                    ZmienneTag.Cash -= 550;
                    ZmienneTag.clickPower -= 0.15f;
                    //RAM[4].SetActive(false);
                    //RAM[5].SetActive(true);
                    PlayerPrefs.SetInt("RAMlvl", ZmienneTag.RAMlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
                else
                    SFXaudio.Button();
                break;
            case 5:
                //coming soon
                break;
            default:
                break;
        }
    }
    public void DISKup()
    {
        switch (ZmienneTag.DISKlvl)
        {
            case 0:
                if (ZmienneTag.Cash >= 100)
                {
                    SFXaudio.Buy();
                    ZmienneTag.DISKlvl = 1;
                    ZmienneTag.Cash -= 100;
                    ZmienneTag.clickPower -= 0.2f;
                    //DISK[0].SetActive(false);
                    //DISK[1].SetActive(true);
                    PlayerPrefs.SetInt("DISKlvl", ZmienneTag.DISKlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
               // else
                  //  SFXaudio.Button();
                break;
            case 1:
                if (ZmienneTag.Cash >= 200)
                {
                    SFXaudio.Buy();
                    ZmienneTag.DISKlvl = 2;
                    ZmienneTag.Cash -= 150;
                    ZmienneTag.clickPower -= 0.2f;
                    //DISK[1].SetActive(false);
                    //DISK[2].SetActive(true);
                    PlayerPrefs.SetInt("DISKlvl", ZmienneTag.DISKlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
              //  else
                 //   SFXaudio.Button();
                break;
            case 2:
                if (ZmienneTag.Cash >= 350)
                {
                    SFXaudio.Buy();
                    ZmienneTag.DISKlvl = 3;
                    ZmienneTag.Cash -= 300;
                    ZmienneTag.clickPower -= 0.2f;
                    //DISK[2].SetActive(false);
                    //DISK[3].SetActive(true);
                    PlayerPrefs.SetInt("DISKlvl", ZmienneTag.DISKlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
               // else
                //    SFXaudio.Button();
                break;
            case 3:
                if (ZmienneTag.Cash >= 700)
                {
                    SFXaudio.Buy();
                    ZmienneTag.DISKlvl = 4;
                    ZmienneTag.Cash -= 450;
                    ZmienneTag.clickPower -= 0.2f;
                    //DISK[3].SetActive(false);
                    //DISK[4].SetActive(true);
                    PlayerPrefs.SetInt("DISKlvl", ZmienneTag.DISKlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
               // else
                 //   SFXaudio.Button();
                break;
            case 4:
                if (ZmienneTag.Cash >= 1500)
                {
                    SFXaudio.Buy();
                    ZmienneTag.DISKlvl = 5;
                    ZmienneTag.Cash -= 600;
                    ZmienneTag.clickPower -= 0.25f;
                    //DISK[4].SetActive(false);
                    //DISK[5].SetActive(true);
                    PlayerPrefs.SetInt("DISKlvl", ZmienneTag.DISKlvl);
                    PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
                    PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
                }
                //else
                 //   SFXaudio.Button();
                break;
            case 5:
                //coming soon
                break;
            default:
                break;
        }
    }
    public void CASHup()
    {
        ZmienneTag.Cash += 1000;
        PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
    }
    public void Money ()
        {
        cash.text = "" + ZmienneTag.Cash;
        }
}
