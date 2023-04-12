using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script03 : MonoBehaviour
{
    [SerializeField]
    public float inch;
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
