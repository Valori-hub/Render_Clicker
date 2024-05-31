using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debuger : MonoBehaviour {
    public QuestProgress questProgress;
    public GameObject clicker;
    //public QuestSystem questSystem;

    private void Update()
    {
        //Debug.Log("time " + ZmienneTag.time);
        //Debug.Log("lvl " + ZmienneTag.LVL);
        //Debug.Log("isquesttaken " + ZmienneTag.isQuestTaken);
        //Debug.Log("clickpower " + ZmienneTag.clickPower);
        //Debug.Log("quests " + ZmienneTag.completedQuests);
        //Debug.Log("min " + questProgress.progressBar.minValue);
        //Debug.Log("max " + questProgress.progressBar.maxValue);

        //Debug.Log("Title: " + QuestSystem.GetQuest()["title"]);
        //Debug.Log("Message: " + QuestSystem.GetQuest()["message"]);
        //Debug.Log("Name: " + QuestSystem.GetQuest()["name"]);
        //Debug.Log("Salary: " + int.Parse(QuestSystem.GetQuest()["salary"]));
        //Debug.Log("Salary type: " + int.Parse(QuestSystem.GetQuest()["salary"]).GetType());
        if (Input.touchCount > 0)
        {
            Debug.Log("touchRaw " + Input.touches[0].position);
            Debug.Log("touchWorld " + Camera.main.ScreenToWorldPoint(new Vector3(Input.touches[0].position.x, Input.touches[0].position.y)));
        }

    }
}
