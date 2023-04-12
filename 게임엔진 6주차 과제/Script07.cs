using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script07 : MonoBehaviour
{
    public class InchToCm
    {
        public float inch;
        public float cm;

        public void ChangeInchToCm()
        {
            cm = inch * 2.54f;
        }

        public void PrintCm()
        {
            Debug.Log(cm);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        InchToCm myinch = new InchToCm();

        myinch.inch = 5.5f;
        myinch.ChangeInchToCm();
        myinch.PrintCm();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
