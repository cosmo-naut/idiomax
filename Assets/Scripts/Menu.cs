using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button GenerateButton;
    public RectTransform GenerateButtonText;
    public Text OutputText;

    private void Awake() 
    {
        GenerateButton.onClick.AddListener(GenerateIdiom);
        GenerateButton.onClick.AddListener(MoveButtonText);
    }
    private void GenerateIdiom()
    {
        OutputText.text = string.Format("\"{0}\"", Generator.Generate().ToUpper());
    }
    private void MoveButtonText()
    {
        GenerateButtonText.eulerAngles = new Vector3
        (
            Random.Range(-10,10),
            Random.Range(-10,10),
            Random.Range(-10,10)
        );
    }
}
