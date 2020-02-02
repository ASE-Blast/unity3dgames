using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public GameObject completeLevelUI;
    bool gameHasEnded;
    int restartDelay = 3;

    public GameObject explode;
    public GameObject trail;
    public GameObject emit;
    public AudioSource explosionSound;

    public CamerShake cameraShake;

    void Start()
    {
        completeLevelUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void PlayerCollidesWall()
    {
        if(gameHasEnded == false)
        {
            explode.SetActive(true);
            trail.SetActive(true);
            emit.SetActive(true);
            explosionSound.Play();
            StartCoroutine(cameraShake.Shake(3f, 1.5f));

            player.SetActive(false);
            gameHasEnded = true;
            Debug.Log("GameOver");
            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

}
