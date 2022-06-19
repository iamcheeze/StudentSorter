using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentPersonalityHolder : MonoBehaviour
{
    public List<string> neutralList = new List<string>();
    public List<string> badList = new List<string>();
    public List<string> goodList = new List<string>();

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
