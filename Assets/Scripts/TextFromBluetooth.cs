using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextFromBluetooth : MonoBehaviour
{
    public GameObject screens;

    public void WriteMessage(string texto){
        screens.GetComponent<ConsoleController>().writeStringConsole(texto);
    }
}
