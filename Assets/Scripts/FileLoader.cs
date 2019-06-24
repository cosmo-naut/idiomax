using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileLoader : MonoBehaviour
{
    // Start is called before the first frame update

    public static List<string> LoadFiles(TextAsset _file)
    {
        var lines = _file.text.Split('\n');
        var idioms = new List<string>();
        string idiom;
        foreach (string line in lines)
        {
            idiom = line;
            if (line.Length < 4)
            {
                continue;
            }

            if (line.Contains(" - A"))
            {
                idiom = "A " + line.Remove(line.Length - 4);
            }

            if (line.Contains(" - The"))
            {
                idiom = "The " + line.Remove(line.Length - 6);
            }

            if (line.Contains(" - It"))
            {
                idiom = "It " + line.Remove(line.Length - 5);
            }

            if (line.Contains(" - It's"))
            {
                idiom = "It's " + line.Remove(line.Length - 7);
            }

            if (line.Contains(" - There's"))
            {
                idiom = "There's " + line.Remove(line.Length - 10);
            }

            if (line.Contains(" - An"))
            {
                idiom = "An " + line.Remove(line.Length - 5);
            }

            idioms.Add(idiom);
        }

        Debug.Log(string.Format("Added {0} idioms.", idioms.Count));

        return idioms;
    }

}
