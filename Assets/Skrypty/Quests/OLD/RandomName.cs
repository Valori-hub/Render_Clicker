using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

public class RandomName : MonoBehaviour
{
    public string[] names = new string[75]; //creating array

    private void Start() //reading names from files
    {

        if (File.Exists("Assets/Skrypty/Quests/Names.txt")) //checking if files exists
	    {
            Debug.Log("Names exist");
            var fileStream = new FileStream("Assets/Skrypty/Names.txt", FileMode.Open, FileAccess.Read); //creating filestream to read file
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8)) //uses streamreder to read file line by line
            {
                string line;
                int i = 0;
                while ((line = streamReader.ReadLine()) != null) //adding read line to next array element
                {
                    names[i] = line;
                    i++;
                }
            }
        }
        else
        {
            Debug.Log("Names doesnt exist");
        }

    }

    
    string GanerateName() //generating random name and returning it
    {
        return (names[Random.Range(0, 74)]);
    }
}
