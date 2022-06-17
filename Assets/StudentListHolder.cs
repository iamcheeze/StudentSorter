using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StudentListHolder : MonoBehaviour
{
    public static List<string> studentList = new List<string>();
    public string input;
    public TMP_InputField inputFieldText;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        input = inputFieldText.text;
        studentList.Add(input);
    }
}
