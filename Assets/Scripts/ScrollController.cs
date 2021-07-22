using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollController : MonoBehaviour
{
    public ScrollRect scrollRect;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var pos = new Vector2(0f, Mathf.Sin(Time.time * 10f) * 100f);
        scrollRect.content.localPosition = pos;
    }
}
