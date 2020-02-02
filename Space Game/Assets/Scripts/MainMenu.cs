using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadLevel01()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        PauseMenu pause = gameObject.GetComponent<PauseMenu>();
        pause.Resume();
        Time.timeScale = 1;
    }
    public void LoadLevel02()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
        PauseMenu pause = gameObject.GetComponent<PauseMenu>();
        pause.Resume();
        Time.timeScale = 1;
    }
    public void LoadLevel03()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
        PauseMenu pause = gameObject.GetComponent<PauseMenu>();
        pause.Resume();
        Time.timeScale = 1;
    }
    public void LoadLevel04()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        PauseMenu pause = gameObject.GetComponent<PauseMenu>();
        pause.Resume();
        Time.timeScale = 1;
    }
    public void LoadLevel05()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
        PauseMenu pause = gameObject.GetComponent<PauseMenu>();
        pause.Resume();
        Time.timeScale = 1;
    }
}
