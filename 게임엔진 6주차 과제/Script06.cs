using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script06 : MonoBehaviour
{
    [SerializeField]
    public float inch;
    float Changeinch(float inch)
    {
        float result = inch * 2.54f;
        return result;
    }
    // Start is called before the first frame update
    void Start()
    {
        float ret = Changeinch(inch);
        Debug.Log(ret);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
