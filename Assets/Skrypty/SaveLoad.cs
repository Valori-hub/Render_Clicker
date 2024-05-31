using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoad : MonoBehaviour
{
    public Buttons buttons;
    public QuestProgress questProgress;
    void Awake()
    {
        Load();
    }
    public void Save()
    {
        PlayerPrefs.SetInt("Cash", ZmienneTag.Cash);
        PlayerPrefs.SetInt("CPUlvl", ZmienneTag.CPUlvl);
        PlayerPrefs.SetInt("GPUlvl", ZmienneTag.GPUlvl);
        PlayerPrefs.SetInt("RAMlvl", ZmienneTag.RAMlvl);
        PlayerPrefs.SetInt("DISKlvl", ZmienneTag.DISKlvl);
        PlayerPrefs.SetFloat("clickPower", ZmienneTag.clickPower);
        PlayerPrefs.SetInt("lvl", ZmienneTag.LVL);
        PlayerPrefs.SetFloat("time", ZmienneTag.time);
        PlayerPrefs.SetInt("reward", ZmienneTag.reward);
        PlayerPrefs.SetInt("completedQuests", ZmienneTag.completedQuests);
        PlayerPrefs.SetInt("isQuestTaken", ZmienneTag.isQuestTaken);
        PlayerPrefs.SetFloat("ProgressMin", questProgress.progressBar.minValue);

        QuestSave.SaveQuests();
    }

    public void Load()
    {
        if (PlayerPrefs.HasKey("Cash") || PlayerPrefs.HasKey("CPUlvl") || PlayerPrefs.HasKey("clickPower") ||
            PlayerPrefs.HasKey("GPUlvl") || PlayerPrefs.HasKey("DISKlvl") || PlayerPrefs.HasKey("LVL") ||
            PlayerPrefs.HasKey("time") || PlayerPrefs.HasKey("reward") || PlayerPrefs.HasKey("completedQuests") ||
            PlayerPrefs.HasKey("isQuestTaken") || PlayerPrefs.HasKey("ProgressMin"))
        {
            ZmienneTag.Cash = PlayerPrefs.GetInt("Cash");
            ZmienneTag.CPUlvl = PlayerPrefs.GetInt("CPUlvl");
            ZmienneTag.GPUlvl = PlayerPrefs.GetInt("GPUlvl");
            ZmienneTag.RAMlvl = PlayerPrefs.GetInt("RAMlvl");
            ZmienneTag.DISKlvl = PlayerPrefs.GetInt("DISKlvl");
            ZmienneTag.clickPower = PlayerPrefs.GetFloat("clickPower");
            ZmienneTag.LVL = PlayerPrefs.GetInt("lvl");
            ZmienneTag.time = PlayerPrefs.GetFloat("time");
            ZmienneTag.reward = PlayerPrefs.GetInt("reward");
            ZmienneTag.completedQuests = PlayerPrefs.GetInt("completedQuests");
            ZmienneTag.isQuestTaken = PlayerPrefs.GetInt("isQuestTaken");
            questProgress.progressBar.minValue = PlayerPrefs.GetFloat("ProgressMin");

            QuestData data = QuestSave.LoadQuests();

            ZmienneTag.Quest1 = data.Quest1;

            ZmienneTag.Quest2 = data.Quest2;
            ZmienneTag.Quest3 = data.Quest3;
            ZmienneTag.Quest4 = data.Quest4;
            ZmienneTag.Quest5 = data.Quest5;
        }
        else
            Save();
    }
}
