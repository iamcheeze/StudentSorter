using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoodGrouper : MonoBehaviour
{
    StudentPersonalityHolder sph;

    public TextMeshProUGUI text1;
    public TextMeshProUGUI text2;
    public TextMeshProUGUI text3;
    public TextMeshProUGUI text4;

    void Start()
    {
        GameObject holder = GameObject.Find("Bad Or Good Holder");
        sph = holder.GetComponent<StudentPersonalityHolder>();

        Neutral(text1);
        Neutral(text2);
        Neutral(text3);
        Neutral(text4);
    }

    void Neutral(TextMeshProUGUI textObject)
    {
        if (sph.goodList.Count != 0)
        {
            int randomStudent = Random.Range(0, sph.goodList.Count);
            textObject.text = sph.goodList[randomStudent];
            textObject.color = Color.green;
            sph.goodList.RemoveAt(randomStudent);
        }
        else if (sph.goodList.Count == 0)
        {
            if (sph.neutralList.Count != 0)
            {
                int randomStudent = Random.Range(0, sph.neutralList.Count);
                textObject.text = sph.neutralList[randomStudent];
                sph.neutralList.RemoveAt(randomStudent);
            }
            else if (sph.neutralList.Count == 0)
            {
                int randomStudent = Random.Range(0, sph.badList.Count);
                textObject.text = sph.badList[randomStudent];
                textObject.color = Color.red;
                sph.badList.RemoveAt(randomStudent);
            }
        }
    }
}
