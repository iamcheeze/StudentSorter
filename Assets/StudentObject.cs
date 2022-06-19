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

    public AudioSource neutral;
    public AudioSource bad;
    public AudioSource good;

    public StudentPersonalityHolder sph;

    // Start is called before the first frame update
    void Start()
    {
        textmesh = GetComponent<TextMeshProUGUI>();
        GameObject list = GameObject.Find("List");
        StudentListHolder sLH = list.GetComponent<StudentListHolder>();
        anim = GetComponent<Animator>();

        textmesh.text = sLH.studentList[indexRep];
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ListSorter();
        }
    }

    void OnMouseDown()
    {
        anim.SetTrigger("toggle");
    }

    public void Good()
    {
        isGood = true;
        isBad = false;
        good.Play();
    }

    public void Bad()
    {
        isGood = false;
        isBad = true;
        bad.Play();
    }

    public void Neutral()
    {
        isGood = false;
        isBad = false;
        neutral.Play();
    }

    void ListSorter()
    {
        if (isGood && isBad == false) //if good
        {
            sph.goodList.Add(textmesh.text);
        }
        else if (isGood == false && isBad) //if bad
        {
            sph.badList.Add(textmesh.text);
        }
        else
        {
            sph.neutralList.Add(textmesh.text); //if neutral
        }
    }
}
