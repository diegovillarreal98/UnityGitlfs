using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EscenaJuego()
    {
        SceneManager.LoadScene("GalleryView");
    }

    public void EscenaCredits()
    {
        SceneManager.LoadScene("Credits");
    }

    public void EscenaMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
