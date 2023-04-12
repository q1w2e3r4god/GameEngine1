using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script05 : MonoBehaviour
{
    [SerializeField]
    public int num;
    int numsum(int num)
    {
        int sum = num*(num+1)/2;
        return sum;
    }
    // Start is called before the first frame update
    void Start()
    {
        int result = numsum(num);
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
