using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script04 : MonoBehaviour
{
    [SerializeField]
    public int score;
    private string grade;
    string ChangeGrade(int score)
    {
        if (score >= 80)
        {
            grade = "���";
        }
        else if (score >= 60)
        {
            grade = "����";
        }
        else
        {
            grade = "����";
        }

        return grade;
    }
    // Start is called before the first frame update
    void Start()
    {
        string result = ChangeGrade(score);
        Debug.Log(result);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
