using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Aurora2 : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("GalleryView");

    }
    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("VistaAurora2");
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}
