using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextDrawStats : MonoBehaviour
{
    private static string[] objNames = new string[]
    {
        "healthQuanity",
        "hungerQuanity",
        "thirstQuanity",
        "mindQuanity"
    };

    public static string getObjName(int index)
    {
        return objNames[index];
    }

    public static string uiCanvasPath { get; set; } = "/[INTERFACE]/UiCanvas/";

    public static GameObject findObjOnPath(string pathCanvas, string inputName)
    {
        return GameObject.Find(pathCanvas + inputName);
    }

    public static void changeText(GameObject includeObj, string text)
    {
        includeObj.GetComponent<Text>().text = text;
    }

    public static void changeText(GameObject includeObj, int numbersInt)
    {
        includeObj.GetComponent<Text>().text = System.Convert.ToString(numbersInt);
    }

    public static void changeText(GameObject includeObj, float numbersFloat)
    {
        includeObj.GetComponent<Text>().text = System.Convert.ToString(Mathf.Round(numbersFloat));
    }

    public static void changeStatsText()
    {
        changeText(findObjOnPath(uiCanvasPath, getObjName(0)), Stats.Health);
        changeText(findObjOnPath(uiCanvasPath, getObjName(1)), Stats.Hunger);
        changeText(findObjOnPath(uiCanvasPath, getObjName(2)), Stats.Thirst);
        changeText(findObjOnPath(uiCanvasPath, getObjName(3)), Stats.Mind);
    }

    void Start() { }

    void Update()
    {
        changeStatsText();
    }
}
