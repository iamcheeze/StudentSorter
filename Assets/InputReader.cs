using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputReader : MonoBehaviour
{
    public List<string> studentList = new List<string>();
    public TextMeshProUGUI textList;
    public TMP_InputField inputFieldText;
    public TextMeshProUGUI numOfStudentsCounter;
    public string s;
    public int numOfStudents = 0;

    public Animator inputFieldAnim;
    public Animator listAnim;
    public Animator numOfStudentsAnim;
    public Animator caminator;

    public AudioSource nope;
    public AudioSource added;
    public AudioSource bloop;

    void Update()
    {
        s = inputFieldText.text;
        textList.text = ListToText(studentList);
        numOfStudentsCounter.text = numOfStudents.ToString();

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            studentList.RemoveAt(studentList.Count - 1);
            numOfStudents--;
            numOfStudentsAnim.Play("Bloop");
            caminator.Play("Camera Shake");
            nope.Play();
        }

        if (numOfStudents < 0)
        {
            numOfStudentsAnim.Play("Bloop");
            numOfStudents++;
        }

        if (numOfStudents > 16)
        {
            studentList.RemoveAt(studentList.Count - 1);
            numOfStudents--;
            listAnim.Play("Nope List");
            nope.Play();

            numOfStudentsAnim.Play("Bloop");
            caminator.Play("Camera Shake");
        }
    }

    public void ReadStringInput(string input)
    {
        if (inputFieldText.text != "")
        {
            input = s;
            studentList.Add(input);
            numOfStudents++;
            inputFieldText.text = "";
            listAnim.Play("List Bop");
            inputFieldAnim.Play("Bloop");
            numOfStudentsAnim.Play("Bloop");
            bloop.Play();
        }
        else
        {
            inputFieldAnim.Play("Nope");
            caminator.Play("Camera Shake");
            nope.Play();
        }
    }

    string ListToText(List<string> list)
    {
        string result = "";
        foreach (var listMember in list)
        {
            result += listMember + "\n";
        }
        return result;
    }

    public void SelectAnim()
    {
        inputFieldAnim.Play("Bop");
        bloop.Play();
    }
}
