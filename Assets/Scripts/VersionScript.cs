using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VersionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>().text = "Control Bluetooth ML v" + Application.version;     
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
