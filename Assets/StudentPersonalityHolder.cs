using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentPersonalityHolder : MonoBehaviour
{
    public StudentObject student;

    public bool isGood;
    public bool isBad;

    void Update()
    {
        isBad = student.isBad;
        isGood = student.isGood;
    }
}
