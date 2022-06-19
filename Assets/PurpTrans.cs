using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PurpTrans : MonoBehaviour
{
    public string scene;

    public void Scene()
    {
        SceneManager.LoadScene(scene);
    }

    public void Disable()
    {
        gameObject.SetActive(false);
    }
}
