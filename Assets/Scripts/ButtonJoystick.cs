using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonJoystick : MonoBehaviour
{
    public GameObject bluetooth;
    public GameObject consoleController;

    public GraphicRaycaster graphicRaycaster;
    private PointerEventData pointerEventData;
    private List<RaycastResult> raycastResults;
    //public GameObject objetoSeleccionado;
    private bool imprimeMensaje = true;
    private bool modo_especial = false;

    private string e_adelante = "adelante especial;";
    private string e_atras = "atras especial;";
    private string e_izquierda = "izquierda especial;";
    private string e_derecha = "derecha especial;";
    private string e_parar = "parar especial;";
    private string e_a = "a especial;";
    private string e_b = "b especial;";
    private string e_c = "c especial;";
    private string e_d = "d especial;";
    private string adelante = "adelante;";
    private string atras = "atras;";
    private string derecha = "derecha;";
    private string izquierda = "izquierda;";
    private string parar = "parar;";
    private string botona = "a;";
    private string botonb = "b;";
    private string botonc = "c;";
    private string botond = "d;";
    private string especial = "especial;";
    // Start is called before the first frame update
    void Start()
    {
        pointerEventData = new PointerEventData(null);
        raycastResults = new List<RaycastResult>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            pointerEventData.position = Input.mousePosition;
            graphicRaycaster.Raycast(pointerEventData, raycastResults);
            if (raycastResults.Count > 0)
            {
                if (raycastResults[0].gameObject.tag.Equals("Controls"))
                {
                    objetoSeleccionado = raycastResults[0].gameObject;
                    
                    if (objetoSeleccionado.gameObject.transform.name.Equals("ButtonUp") && !cambioAvanzar)
                    {
                        AccionARealizarML("avanzar");
                        cambioAvanzar = !cambioAvanzar;
                    }
                    else if (objetoSeleccionado.gameObject.transform.name.Equals("ButtonDown") && !cambioRetroceder)
                    {
                        AccionARealizarML("retroceder");
                        cambioRetroceder = !cambioRetroceder;
                    }
                    else if (objetoSeleccionado.gameObject.transform.name.Equals("ButtonLeft") && !cambioGirarIzquierda)
                    {
                        AccionARealizarML("izquierda");
                        cambioGirarIzquierda = !cambioGirarIzquierda;
                    }
                    else if (objetoSeleccionado.gameObject.transform.name.Equals("ButtonRight") && !cambioGirarDerecha)
                    {
                        AccionARealizarML("derecha");
                        cambioGirarDerecha = !cambioGirarDerecha;
                    }
                    else if (objetoSeleccionado.gameObject.transform.name.Equals("ButtonA") && !cambioRetroceder)
                    {
                        AccionARealizarML("retroceder");
                        cambioRetroceder = !cambioRetroceder;
                    }
                    else if (objetoSeleccionado.gameObject.transform.name.Equals("ButtonB") && !cambioGirarIzquierda)
                    {
                        AccionARealizarML("izquierda");
                        cambioGirarIzquierda = !cambioGirarIzquierda;
                    }
                    else if (objetoSeleccionado.gameObject.transform.name.Equals("ButtonC") && !cambioGirarDerecha)
                    {
                        AccionARealizarML("derecha");
                        cambioGirarDerecha = !cambioGirarDerecha;
                    }
                    else if (objetoSeleccionado.gameObject.transform.name.Equals("ButtonD") && !cambioRetroceder)
                    {
                        AccionARealizarML("retroceder");
                        cambioRetroceder = !cambioRetroceder;
                    }
                    else if (objetoSeleccionado.gameObject.transform.name.Equals("ButtonStop") && !cambioGirarIzquierda)
                    {
                        AccionARealizarML("izquierda");
                        cambioGirarIzquierda = !cambioGirarIzquierda;
                    }
                    else if (objetoSeleccionado.gameObject.transform.name.Equals("ButtonSpecial") && !cambioGirarDerecha)
                    {
                        AccionARealizarML("derecha");
                        cambioGirarDerecha = !cambioGirarDerecha;
                    }
                   
                }
            }
        }

        if (objetoSeleccionado != null && Input.GetMouseButtonUp(0))
        {
            pointerEventData.position = Input.mousePosition;
            raycastResults.Clear();
            graphicRaycaster.Raycast(pointerEventData, raycastResults);

            if (raycastResults.Count > 0)
            {
                foreach (var resultado in raycastResults)
                {
                  
                    if (resultado.gameObject.transform.name.Equals("ButtonUp"))
                    {
                        cambioAvanzar = !cambioAvanzar;
                        bluetooth.GetComponent<BluetoothHandlerSystems>().EnviarString(mJParar);
                    }
                    else if (resultado.gameObject.transform.name.Equals("ButtonDown"))
                    {
                        cambioRetroceder = !cambioRetroceder;
                        bluetooth.GetComponent<BluetoothHandlerSystems>().EnviarString(mJParar);
                    }
                    else if (resultado.gameObject.transform.name.Equals("ButtonLeft"))
                    {
                        cambioGirarIzquierda = !cambioGirarIzquierda;
                        bluetooth.GetComponent<BluetoothHandlerSystems>().EnviarString(mJParar);
                    }
                    else if (resultado.gameObject.transform.name.Equals("ButtonRight"))
                    {
                        cambioGirarDerecha = !cambioGirarDerecha;
                        bluetooth.GetComponent<BluetoothHandlerSystems>().EnviarString(mJParar);
                    }
                    
                }

            }
            objetoSeleccionado = null;

        }
        if (raycastResults != null)
            raycastResults.Clear();*/
    }

    

    public void AccionARealizarML(string accion)
    {
       
        switch(accion){
            case "avanzar":
                bluetooth.GetComponent<BluetoothHandlerSystems>().EnviarString(modo_especial ? e_adelante : adelante);
                if(imprimeMensaje){
                    consoleController.GetComponent<ConsoleController>().writeStringConsole("Se envia: " + (modo_especial ? e_adelante : adelante));
                }
                break;
            case "retroceder":
                bluetooth.GetComponent<BluetoothHandlerSystems>().EnviarString(modo_especial ? e_atras : atras);
                if (imprimeMensaje)
                {
                    consoleController.GetComponent<ConsoleController>().writeStringConsole("Se envia: " + (modo_especial ? e_atras : atras));
                }
                break;
            case "izquierda":
                bluetooth.GetComponent<BluetoothHandlerSystems>().EnviarString(modo_especial ? e_izquierda : izquierda);
                if (imprimeMensaje)
                {
                    consoleController.GetComponent<ConsoleController>().writeStringConsole("Se envia: " + (modo_especial ? e_izquierda : izquierda));
                }
                break;
            case "derecha":
                bluetooth.GetComponent<BluetoothHandlerSystems>().EnviarString(modo_especial ? e_derecha : derecha);
                if (imprimeMensaje)
                {
                    consoleController.GetComponent<ConsoleController>().writeStringConsole("Se envia: " + (modo_especial ? e_derecha : derecha));
                }
                break;
            case "buttonA":
                bluetooth.GetComponent<BluetoothHandlerSystems>().EnviarString(modo_especial ? e_a : botona);
                if (imprimeMensaje)
                {
                    consoleController.GetComponent<ConsoleController>().writeStringConsole("Se envia: " + (modo_especial ? e_a : botona));
                }
                break;
            case "buttonB":
                bluetooth.GetComponent<BluetoothHandlerSystems>().EnviarString(modo_especial ? e_b : botonb);
                if (imprimeMensaje)
                {
                    consoleController.GetComponent<ConsoleController>().writeStringConsole("Se envia: " + (modo_especial ? e_b : botonb));
                }
                break;
            case "buttonC":
                bluetooth.GetComponent<BluetoothHandlerSystems>().EnviarString(modo_especial ? e_c : botonc);
                if (imprimeMensaje)
                {
                    consoleController.GetComponent<ConsoleController>().writeStringConsole("Se envia: " + (modo_especial ? e_c : botonc));
                }
                break;

            case "buttonD":
                bluetooth.GetComponent<BluetoothHandlerSystems>().EnviarString(modo_especial ? e_d : botond);
                if (imprimeMensaje)
                {
                    consoleController.GetComponent<ConsoleController>().writeStringConsole("Se envia: " + (modo_especial ? e_d : botond));
                }
                break;
            case "buttonStop":
                bluetooth.GetComponent<BluetoothHandlerSystems>().EnviarString(modo_especial ? e_parar : parar);
                if (imprimeMensaje)
                {
                    consoleController.GetComponent<ConsoleController>().writeStringConsole("Se envia: " + (modo_especial ? e_parar : parar));
                }
                break;
            case "buttonSpecial":
                bluetooth.GetComponent<BluetoothHandlerSystems>().EnviarString(especial);
                if (imprimeMensaje)
                {
                    consoleController.GetComponent<ConsoleController>().writeStringConsole("Se envia: " + especial);
                }
                break;

            default: break;
        }
        
    }
    public void setImprimeMensaje(bool estado){
        this.imprimeMensaje = estado;
    }

    public bool getImprimeMensaje(){
        return this.imprimeMensaje;
    }

    public void ChangeModoEspecial(){
        this.modo_especial = !this.modo_especial;
    }

    public void setModoEspecial(bool estado)
    {
        this.modo_especial = estado;
    }

    public bool getModoEspecial()
    {
        return this.modo_especial;
    }

}
