using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputReader : MonoBehaviour
{
    private string input;
    public static List<string> studentList = new List<string>();
    public TextMeshProUGUI textList;
    public TMP_InputField inputFieldText;
    public string s;

    void Start()
    {

    }

    void Update()
    {
        s = inputFieldText.text;
        textList.text = ListToText(studentList);
    }

    public void ReadStringInput(string input)
    {
        input = s;
        studentList.Add(input);
    }

    private string ListToText(List<string> list)
    {
        string result = "";
        foreach (var listMember in list)
        {
            result += listMember.ToString() + "\n";
        }
        return result;
    }
}
