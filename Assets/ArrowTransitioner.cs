using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ArrowTransitioner : MonoBehaviour
{
    public Animator anim;
    public InputReader iR;
    public SpriteRenderer sr;

    void Update()
    {
        Color c = sr.color;

        if (iR.numOfStudents == 16)
        {
            c.a = 1f;
        }

        if (iR.numOfStudents < 16)
        {
            c.a = .27f;
        }

        sr.color = c;
    }

    void OnMouseDown()
    {
        if (iR.numOfStudents == 16)
        {
            SceneManager.LoadScene("StudentSorting");
        }
    }

    void OnMouseOver()
    {
        if (iR.numOfStudents == 16)
            anim.Play("speen");
    }

    void OnMouseExit()
    {
        if (iR.numOfStudents == 16)
            anim.Play("Idle");
    }
}
