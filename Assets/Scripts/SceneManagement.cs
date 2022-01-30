using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [SerializeField]
    private GameObject AboutScreen;

    [SerializeField]
    private GameObject CreditsScreen;
    private void Awake()
    {
        AboutScreen.SetActive(false);
        CreditsScreen.SetActive(false);
    }
    public void Play()
    {
        SceneManager.LoadScene("Conway");
    }

    public void About()
    {
        AboutScreen.SetActive(true);
    }

    public void Credits()
    {
        CreditsScreen.SetActive(true);
    }

    public void Back()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void Quit()
    {
        Application.Quit();
    }
}
