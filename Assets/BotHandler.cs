using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotHandler : MonoBehaviour
{
    public GameObject canvas;
    public GameObject particles;
    public Transform spawn;
    public GameObject bx2d;

    public void Kill()
    {
        Destroy(canvas);
        Instantiate(particles, spawn.position, spawn.rotation);
        bx2d.SetActive(true);
    }
}
