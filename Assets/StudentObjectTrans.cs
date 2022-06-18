using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StudentObjectTrans : MonoBehaviour
{
    public Animator anim;

    public bool boolean = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && !boolean)
        {
            anim.SetTrigger("down");
        }
        else
            SceneManager.LoadScene("StudentSortingFinal");
    }
}
