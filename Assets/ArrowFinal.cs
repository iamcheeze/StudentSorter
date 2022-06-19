using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowFinal : MonoBehaviour
{
    public Animator purpAnim;
    public Animator anim;
    public GameObject purp;

    public AudioSource sound;

    void OnMouseDown()
    {
        purp.SetActive(true);
        purpAnim.Play("end");
        sound.Play();
    }

    void OnMouseExit()
    {
        anim.Play("Idle");
    }

    void OnMouseOver()
    {
        anim.Play("speen");
    }
}
