using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public int index;

    public int killNum;
    public Animator botAnim;
    public Animator speechBubbleAnim;

    void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();
    }

    void Update()
    {
        //input
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (textComponent.text == lines[index])
            {
                NextLine();
                speechBubbleAnim.Play("boop");
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }

        if (index == killNum)
        {
            botAnim.SetTrigger("down");
        }
    }

    //waits a bit, then starts the convo
    public void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    //cool char by char word print like Undertale
    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    //adds to index, goes to next line
    void NextLine()
    {
        if(index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}