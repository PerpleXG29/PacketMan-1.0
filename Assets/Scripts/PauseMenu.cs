using System;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenuCanvas;
    public AudioSource pauseAudio;
    public AudioSource unpauseAudio;

    private bool isPaused = false;

    private void Start()
    {
        // Disable the pause menu canvas by default
        pauseMenuCanvas.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    private void TogglePause()
    {
        if (isPaused == false)
        {
            isPaused = true;
            pauseMenuCanvas.SetActive(true);
            pauseAudio.Play();
            Time.timeScale = 0;
            Debug.Log("UnPause");
        }
        else
        {
            isPaused = false;
            pauseMenuCanvas.SetActive(false);
            unpauseAudio.Play();
            Time.timeScale = 1;
            Debug.Log("Pause");
        }
    }
}
