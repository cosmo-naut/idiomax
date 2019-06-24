using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    public TextAsset file;

    private void Awake() {
        Screen.SetResolution(600,800,false);    
    }
    void Start()
    {
        Generator.Input(FileLoader.LoadFiles(file));

        //Generator.Generate();
    }

}
