using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public static PlayerState currentState;
    public enum PlayerState
    {
        Preparing,
        Playing,
        Death,
        Shooting,
        Finish,
    }
    private void Start()
    {
        currentState = PlayerState.Preparing;
    }

    public void ChangePlayerState(PlayerState state)
    {
        currentState = state;
    }

    private void Update()
    {
        if (FindObjectOfType<ParcacikCreaterScript>().topSayisi < -2)
        {
            Debug.Log("Finished");
            Time.timeScale = 0;
            currentState = PlayerState.Death;
        }
    }

    public void retry()
    {
        SceneManager.LoadScene(0);
    }

    public void nextLevel()
    {
        PlayerPrefs.SetInt("Level", PlayerPrefs.GetInt("Level") + 1);
        SceneManager.LoadScene(0);
    }
}
