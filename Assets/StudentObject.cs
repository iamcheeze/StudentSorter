using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StudentObject : MonoBehaviour
{
    public int indexRep;
    TextMeshProUGUI textmesh;
    Animator anim;

    public bool isGood;
    public bool isBad;

    // Start is called before the first frame update
    void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
        GameObject list = GameObject.Find("List");
        StudentListHolder sLH = list.GetComponent<StudentListHolder>();
        anim = GetComponent<Animator>();

        textmesh.text = sLH.studentList[indexRep];
    }

    void OnMouseDown()
    {
        anim.SetTrigger("toggle");
    }

    public void Good()
    {
        isGood = true;
        isBad = false;
    }

    public void Bad()
    {
        isGood = false;
        isBad = true;
    }

    public void Neutral()
    {
        isGood = false;
        isBad = false;
    }
}
