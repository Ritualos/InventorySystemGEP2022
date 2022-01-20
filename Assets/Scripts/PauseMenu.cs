using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject inventoryUI;

    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
                inventoryUI.SetActive(!inventoryUI.activeSelf); //inverts the state that the UI is in (active/inactive)
            }
        }
    }

    public void Resume()
    {
       
        inventoryUI.SetActive(!inventoryUI.activeSelf); //inverts the state that the UI is in (active/inactive)
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void QuitGame()
    {
        Debug.Log("Game Quit");
        Application.Quit();
    }
}