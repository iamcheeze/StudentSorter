using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentSorterTrans : MonoBehaviour
{
    public Animator animm;
    public bool boolean = false;

    public GameObject purp;
    public Animator purpAnim;
    public AudioSource trans;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !boolean)
        {
            animm.SetTrigger("down");
        }
        else if (Input.GetKeyDown(KeyCode.Return) && boolean)
        {
            purp.SetActive(true);
            purpAnim.Play("end");
            trans.Play();
        }
    }
}
