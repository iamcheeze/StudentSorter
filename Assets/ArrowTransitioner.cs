using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowTransitioner : MonoBehaviour
{
    public Animator anim;
    public InputReader iR;
    public SpriteRenderer sr;
    public Animator purpAnim;
    public GameObject purp;
    public AudioSource sound;

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
            purp.SetActive(true);
            purpAnim.Play("end");
            sound.Play();
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
