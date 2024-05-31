using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {
    public GameObject MenuPanel, GamePanel; //MainPanels
    public GameObject InGameShopPanel, InGameResetPanel, InGameSettingsPanel, ZleceniaPanel; //InGamePanels
    public GameObject ResetPanelMenu, SettingsPanelMenu, ShopPanelMenu; //Menu Panels
    public GameObject Logo;
    public GameObject mute, unmute, muteMenu, unmuteMenu;
    public SaveLoad saveLoad;
    public Reklamy reklamy;
    public Audio SFXaudio;

    public AudioSource music;

    private void Awake()
    {
        if (PlayerPrefs.HasKey("LaunchCount"))
        {
            if(PlayerPrefs.GetInt("LaunchCount")==1)
            {
                System.Random random = new System.Random();
                ZmienneTag.Cash = 0;
                ZmienneTag.CPUlvl = 0;
                ZmienneTag.GPUlvl = 0;
                ZmienneTag.RAMlvl = 0;
                ZmienneTag.DISKlvl = 0;
                ZmienneTag.clickPower = -0.5f;
                ZmienneTag.LVL = 1;
                ZmienneTag.time = 0;
                ZmienneTag.reward = 0;
                ZmienneTag.isQuestTaken = 0;
                ZmienneTag.completedQuests = 0;

                ZmienneTag.Quest1 = QuestSystem.GetQuest(random);
                ZmienneTag.Quest2 = QuestSystem.GetQuest(random);
                ZmienneTag.Quest3 = QuestSystem.GetQuest(random);
                ZmienneTag.Quest4 = QuestSystem.GetQuest(random);
                ZmienneTag.Quest5 = QuestSystem.GetQuest(random);
                saveLoad.Save();
            }
        }
        Input.multiTouchEnabled = false;
    }

    void Start()
    {
        saveLoad.Load();

    }

    void Update()
    {
        if (music.mute)
        {
            unmute.SetActive(false);
            mute.SetActive(true);
            unmuteMenu.SetActive(false);
            muteMenu.SetActive(true);
        }
        else
        {
            unmute.SetActive(true);
            mute.SetActive(false);
            unmuteMenu.SetActive(true);
            muteMenu.SetActive(false);
        }
        saveLoad.Save();
    }

    public void Play()
        {
        StartCoroutine(AnimacjaPlay());
    }
    public void Shop()
    {
        if (MenuPanel.activeInHierarchy)
        {
            if (!ShopPanelMenu.activeInHierarchy)
            {
                ShopPanelMenu.SetActive(true);
            }
            else
            {
                ShopPanelMenu.GetComponent<Animator>().Play("ShopZasuńWmenu");
                StartCoroutine(AnimacjaSklepMenu());
            }
                
        }
        else
        {
            if (!InGameShopPanel.activeInHierarchy)
                InGameShopPanel.SetActive(true);
            else
            {
                InGameShopPanel.GetComponent<Animator>().Play("ShopZasuńWgrze");
                StartCoroutine(AnimacjaSklepGra());
            }
                
        }

    }
    public void Settings()
    {
        if(MenuPanel.activeInHierarchy)
        {
            if (!SettingsPanelMenu.activeInHierarchy)
                SettingsPanelMenu.SetActive(true);
            else
            {
                SettingsPanelMenu.GetComponent<Animator>().Play("Zasuń");
                StartCoroutine(AnimacjaUstawieniaMenu());
            }
                
        }
        else
        {
            if (!InGameSettingsPanel.activeInHierarchy)
                InGameSettingsPanel.SetActive(true);
            else
            {
                InGameSettingsPanel.GetComponent<Animator>().Play("Zasuń");
                StartCoroutine(AnimacjaUstawieniaGra());
            }

        }
    }
    public void Reset()
    {
        if (MenuPanel.activeInHierarchy)
        {
            if (!ResetPanelMenu.activeInHierarchy)
                ResetPanelMenu.SetActive(true);
            else
            {
                ResetPanelMenu.GetComponent<Animator>().Play("ZasunReset");
                StartCoroutine(AnimacjaResetMenu());
            }
        }
        else
        {
            if (!InGameResetPanel.activeInHierarchy)
                InGameResetPanel.SetActive(true);
            else
            {
                InGameResetPanel.GetComponent<Animator>().Play("ZasunReset");
                StartCoroutine(AnimacjaResetGra());
            }
        }
    }
    public void ResetConfirm()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Preload");
    }
    public void Zlecenia()
    {
        if (!ZleceniaPanel.activeInHierarchy) 
            ZleceniaPanel.SetActive(true);
        else
        {
            ZleceniaPanel.GetComponent<Animator>().Play("zasunzlecenia");
            StartCoroutine(AnimacjaZlecenia());
        }
    }
    public void toggleMute()
    {
        if (MenuPanel.activeInHierarchy)
        {
            if (music.mute)
            {
                music.mute = false;
                SFXaudio.SFX.mute = false;
                muteMenu.SetActive(false);
                unmuteMenu.SetActive(true);
            }
            else
            {
                music.mute = true;
                SFXaudio.SFX.mute = true;
                muteMenu.SetActive(true);
                unmuteMenu.SetActive(false);
            }
        }
        else
        {
            if (music.mute)
            {
                music.mute = false;
                SFXaudio.SFX.mute = false;
                mute.SetActive(false);
                unmute.SetActive(true);
            }
            else
            {
                music.mute = true;
                SFXaudio.SFX.mute = true;
                mute.SetActive(true);
                unmute.SetActive(false);
            }
        }
    }
    public void Facebook()
    {
        Application.OpenURL("https://www.facebook.com/Appology-Studio-130420730920290/");
    }
    public void Twitter()
    {
        Application.OpenURL("https://twitter.com/appology_studio");
    }
    public void Instagram()
    {
        Application.OpenURL("https://www.instagram.com/appology_studio/");
    }
    public void Reklamy()
    {
        
    }//usuwanie reklam za oplata
  
    #region AniamacjeOpoznienia
    IEnumerator AnimacjaPlay()
    {
        yield return new WaitForSeconds(1);
        MenuPanel.SetActive(false);
        GamePanel.SetActive(true);
    }
    IEnumerator AnimacjaSklepMenu()
    {
        yield return new WaitForSeconds(0.6f);
        ShopPanelMenu.SetActive(false);
    }
    IEnumerator AnimacjaSklepGra()
    {
        yield return new WaitForSeconds(0.6f);
        InGameShopPanel.SetActive(false);
    }
    IEnumerator AnimacjaUstawieniaMenu()
    {
        yield return new WaitForSeconds(0.6f);
        SettingsPanelMenu.SetActive(false);
    }
    IEnumerator AnimacjaUstawieniaGra()
    {
        yield return new WaitForSeconds(0.6f);
        InGameSettingsPanel.SetActive(false);
    }
    IEnumerator AnimacjaResetMenu()
    {
        yield return new WaitForSeconds(0.6f);
        ResetPanelMenu.SetActive(false);
    }
    IEnumerator AnimacjaResetGra()
    {
        yield return new WaitForSeconds(0.6f);
        InGameResetPanel.SetActive(false);
    }
    IEnumerator AnimacjaZlecenia()
    {
        yield return new WaitForSeconds(0.6f);
        ZleceniaPanel.SetActive(false);
    }
    IEnumerator wysunieciezlecenia()
    {
        yield return new WaitForSeconds(0.6f);
        ZleceniaPanel.SetActive(true);
    }
    #endregion



}
