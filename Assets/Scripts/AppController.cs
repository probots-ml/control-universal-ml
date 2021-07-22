using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppController : MonoBehaviour
{
    public GameObject configPanel;
    public GameObject buttonsControl;
    
    void Start()
    {
        
    }


    public void CloseApp(){
        Application.Quit();
    }

    public void HabilitarImpresionMensaje(){
        buttonsControl.GetComponent<ButtonJoystick>().setImprimeMensaje(configPanel.transform.Find("Logs").GetComponent<Toggle>().isOn);
    }


}
