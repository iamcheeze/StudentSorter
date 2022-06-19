using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleController : MonoBehaviour
{
    public Animator purpAnim;
    public AudioSource sound;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            purpAnim.Play("end");
            sound.Play();
        }
    }
}
