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

            GameObject list = GameObject.Find("List");
            GameObject goodobad = GameObject.Find("Bad Or Good Holder");

            Destroy(list);
            Destroy(goodobad);
        }
    }
}
