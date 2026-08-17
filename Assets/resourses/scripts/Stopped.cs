using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stopped : MonoBehaviour
{
    public GameObject PauseScreen;
    public bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            PauseUnPause();
        }
    }

    public void MenuButton() 
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1f;
    }

    public void PauseUnPause() 
    {
        if (isPaused)
        {
            isPaused = false;
            PauseScreen.SetActive(false);
            Time.timeScale = 1f;
        }
        else 
        {
            isPaused = true;
            PauseScreen.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
