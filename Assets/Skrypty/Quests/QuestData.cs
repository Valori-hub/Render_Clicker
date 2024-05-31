using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuestData
{
    public Dictionary<string, string> Quest1;
    public Dictionary<string, string> Quest2;
    public Dictionary<string, string> Quest3;
    public Dictionary<string, string> Quest4;
    public Dictionary<string, string> Quest5;

    public QuestData()
    {
        Quest1 = ZmienneTag.Quest1;
        Quest2 = ZmienneTag.Quest2;
        Quest3 = ZmienneTag.Quest3;
        Quest4 = ZmienneTag.Quest4;
        Quest5 = ZmienneTag.Quest5;
    }
}
