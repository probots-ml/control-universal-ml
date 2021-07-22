using System.Collections;
using System.Collections.Generic;
using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ConsoleController : MonoBehaviour
{

    private TextMeshProUGUI content;
    public GameObject screenText;
    public GameObject consoleScreenText;
    public GameObject containerScreen;
    public GameObject containerConsoleScreen;

    private static string PIPE = "\r\n>";
    public bool consoleMode = true;

    // Start is called before the first frame update
    void Start()
    {
        if(consoleMode){
            content = consoleScreenText.GetComponent<TextMeshProUGUI>();
            containerScreen.SetActive(false);
        }else{
            content = screenText.GetComponent<TextMeshProUGUI>();
            containerConsoleScreen.SetActive(false);
        }
        clearScreenConsole();
        writeStringConsole("Control Bluetooth ML v" + Application.version);
       
    }

    public void writeStringConsole(string data)
    {
        if(consoleMode){
            content.text = content.text + PIPE + data;
        }else{
            content.text = content.text + data;
        }
    }

    public void clearScreenConsole(){
        content.text = "";
    }
 
}
