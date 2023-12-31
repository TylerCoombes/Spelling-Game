using PDollarGestureRecognizer;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RandomLetter : MonoBehaviour
{
    char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
    public char randomChar;
    public Button nextLetter;
    public TextMeshProUGUI text;

    // Start is called before the first frame update
    void Start()
    {
        RandomChar();
        text.text = "Can You Draw " + randomChar + "?";
    }

    /*void OnGUI()
    {
        UpdateGUI();

        //Next Letter text
        GUIStyle NextLetterStyle = new GUIStyle(GUI.skin.button);
        NextLetterStyle.fontSize = 30;

        if(GUI.Button(new Rect(1600, 1000, 200, 40), "NextLetter", NextLetterStyle))
        {
            RandomChar();
        }
    }*/

    public void RandomChar()
    {
        randomChar = alpha[Random.Range(0, 26)];
        Debug.Log(randomChar);
    }

    /*public void UpdateGUI()
    {
        //Can you draw (randomchar) text
        GUIStyle myButtonStyle = new GUIStyle(GUI.skin.button);
        myButtonStyle.fontSize = 50;

        GUI.TextArea(new Rect(400, 230, 500, 50), "Can You Draw " + randomChar + "?", myButtonStyle);
    }*/

    public void NextLetter()
    {
        RandomChar();
        text.text = "Can You Draw " + randomChar + "?";
    }
}
