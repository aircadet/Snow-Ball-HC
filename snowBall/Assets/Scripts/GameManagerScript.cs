using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{
    public static PlayerState currentState;
    public int gold,kickLevel,kickUpgradeGold;

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
        gold = PlayerPrefs.GetInt("Gold", 1000);
        kickLevel = PlayerPrefs.GetInt("KickLevel", 1);
        kickUpgradeGold = kickLevel * 100;



        if (FindObjectOfType<ParcacikCreaterScript>().topSayisi <= -2)
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

        // GOLD ARTIRMA İŞLEMLERİ 
        PlayerPrefs.SetInt("Gold", PlayerPrefs.GetInt("Gold") + 100);
        SceneManager.LoadScene(0);
    }

    public void upgradeKick()
    {
        if (gold >= kickUpgradeGold)
        {
            PlayerPrefs.SetInt("Gold", PlayerPrefs.GetInt("Gold") - kickUpgradeGold);
            PlayerPrefs.SetInt("KickLevel", PlayerPrefs.GetInt("KickLevel") + 1);
        }
        

    }
}
