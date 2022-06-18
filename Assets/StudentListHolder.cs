using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StudentListHolder : MonoBehaviour
{
    public InputReader inputReader;
    public List<string> studentList = new List<string>();

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        inputReader.studentList = studentList;
    }
}
