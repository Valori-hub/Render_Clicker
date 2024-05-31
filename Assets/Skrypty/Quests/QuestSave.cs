using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class QuestSave
{
    public static void SaveQuests()
    {
        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "/quests.apo";
        FileStream stream = new FileStream(path, FileMode.Create);

        QuestData data = new QuestData();

        formatter.Serialize(stream, data);
        stream.Close();
    }
    public static QuestData LoadQuests()
    {
        string path = Application.persistentDataPath + "/quests.apo";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            QuestData data = formatter.Deserialize(stream) as QuestData;
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
