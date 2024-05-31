using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public static class QuestSystem
{
    public static Dictionary<string, string> GetQuest(System.Random random)
    {
        string pathQuests = "Assets/Skrypty/Quests/Quests"; // tutorial how to add quest to file: [odd line number - quest title|even line - quest message]
        string pathNames = "Assets/Skrypty/Quests/Names"; // new name on end of file (make sure there is no blank line at the end)
        if (!File.Exists(pathQuests) || !File.Exists(pathNames)) { throw new FileNotFoundException("File 'Quests' or 'Names' doesn't exists!"); }

        string[] quests = File.ReadAllLines(pathQuests); // read every line from file to array
        string[] names = File.ReadAllLines(pathNames); // read every line from file to array

        Dictionary<string, string> Quest = new Dictionary<string, string>(); //Dictionary that will contain quest title, message, salary and client name
        int i = RandomNumberEven(quests.Length - 1, random); // Selecting random "quest" id from quests array

        Quest.Add("title", quests[i]); // Adding title to quest dict
        Quest.Add("message", quests[i + 1]); // Adding message connected with random title to quest dict
        Quest.Add("name", names[random.Next(0, names.Length - 1)]); // Adding random selected name to quest dict
        Quest.Add("salary", GetSalary(random).ToString()); // Adding salary to quest dict, unfortunate needs to be converted to string
        Quest.Add("time", GetTime(random).ToString()); // Adding time to quest dict, unfortunate needs to be converted to string

        return Quest;
    }
    private static int RandomNumberEven(int max, System.Random random)
    {
        int ans = random.Next(0, max);
        if (ans % 2 == 0) return ans;
        else
        {
            if (ans + 1 <= max) // if not out of max range, ceil the number
                return ans + 1;
            else if (ans - 1 >= 0) // if not out of min range, floor the number
                return ans - 1;
            else return RandomNumberEven(max, random); // anything else, use recursive to get correct even number
        }
    }

    private static int GetSalary(System.Random random) //generating random salary for quest by LVL 
    {

        int lvl = ZmienneTag.LVL;

        switch (lvl)
        {
            case 1:
                return random.Next(5, 25);
            case 2:
                return random.Next(25, 50);
            case 3:
                return random.Next(50, 75);
            case 4:
                return random.Next(100, 125);
            case 5:
                return random.Next(125, 150);
            default:
                if (lvl > 5) { return random.Next(125, 150); }
                break;
        }
        return 0;
    }


    private static int GetTime(System.Random random) //generating random time for quest in range depending on lvl, # to adjust #
    {

        int lvl = ZmienneTag.LVL;

        switch (lvl)
        {
            case 1:
                return random.Next(5, 25);
            case 2:
                return random.Next(25, 50);
            case 3:
                return random.Next(50, 75);
            case 4:
                return random.Next(100, 125);
            case 5:
                return random.Next(125, 150);
            default:
                if (lvl > 5) { return random.Next(125, 150); }
                break;
        }
        return 0;
    }

}