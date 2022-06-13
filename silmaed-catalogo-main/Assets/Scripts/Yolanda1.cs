using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Yolanda1 : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("GalleryView");

    }
    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("VistaYolanda1");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
