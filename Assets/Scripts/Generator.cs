using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Generator : MonoBehaviour
{
    private Generator instance;
    private static List<string> IdiomList;
    private static int lowerLimit;
    private static int upperLimit;

    private void Start() {
        instance = this;
    }
    public static void Input(List<string> strings)
    {
        lowerLimit = 0;
        upperLimit = strings.Count;
        IdiomList = strings;
    }

    public static string Generate()
    {
        var firstIdiom = IdiomList[GetRandom()].Split(' ');
        var secondIdiom = IdiomList[GetRandom()].Split(' ');

        var firstSentence = string.Join(" ", firstIdiom.Take(firstIdiom.Length / 2).ToArray());
        var secondSentence = string.Join(" ", secondIdiom.Skip(secondIdiom.Length / 2).ToArray());
        

        return firstSentence + " " + secondSentence;
    }

    private static int GetRandom()
    {
        return Random.Range(lowerLimit, upperLimit);
    }
}
