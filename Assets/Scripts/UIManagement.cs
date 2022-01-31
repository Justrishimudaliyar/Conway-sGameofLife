using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManagement : MonoBehaviour
{
    [SerializeField]
    private GameObject SandBoxModePanel;
    [SerializeField]
    private GameObject ReadyMadeModePanel;
    //[SerializeField]
    //private Conways conways;
    // Start is called before the first frame update

    private void Start()
    {
        SandBoxModePanel.SetActive(false);
        ReadyMadeModePanel.SetActive(false);
    }

    public void SandBoxMode()
    {
        SandBoxModePanel.SetActive(true);
    }

    public void ReadymadeMode()
    {
        ReadyMadeModePanel.SetActive(true);
    }

    public void Back()
    {
        SceneManager.LoadScene("GameModeScene");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void PlaySandBoxMode()
    {
        SandBoxModePanel.SetActive(false);
        Conways.randomizeAtStart = false;
        Conways.start = false;
        SceneManager.LoadScene("Conway");
    }

    public void PlayReadyMadeBoxMode()
    {
        ReadyMadeModePanel.SetActive(false);
        Conways.randomizeAtStart = true;
        Conways.start = true;
        SceneManager.LoadScene("Conway");
    }

}
