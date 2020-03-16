using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timecontroller : MonoBehaviour
{
    public GameObject pauseScreen;
    private bool paused = false;

    #region Monobehaviour API

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;

            if (paused)
            {
                Time.timeScale = 0;
                pauseScreen.SetActive(true);
            }
            else
            {
                Time.timeScale = 1;
                pauseScreen.SetActive(false);
            }
        }
    }

    public void resume()
    {
        Time.timeScale = 1;
        pauseScreen.SetActive(false);
    }

    #endregion
}
