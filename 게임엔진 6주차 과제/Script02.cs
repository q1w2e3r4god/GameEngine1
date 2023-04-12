using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Script02 : MonoBehaviour
{
    private float inch = 5.5f;
    private float cm;
    // Start is called before the first frame update
    void Start()
    {
        cm = inch * 2.54f;
        Debug.Log(cm);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
