using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PauseManagement : MonoBehaviour
{
    [SerializeField]
    private GameObject PauseMenuPanel;
    public void Play()
    {
        Time.timeScale = 1f;
        PauseMenuPanel.SetActive(false);
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        PauseMenuPanel.SetActive(true);
    }

    public void ResetGame()
    {
        PauseMenuPanel.SetActive(false);
        SceneManager.LoadScene("GameModeScene");
    }

    public void Quit()
    {
        PauseMenuPanel.SetActive(false);
        SceneManager.LoadScene("StartScene");
    }

}
