using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    public GameObject winParticle;

    private int level;

    public Transform snowBall;

    public Image currentLevelIMG;
    public Text currentLevelText;

    public Image nextLevelIMG;
    public Text nextLevelText;

    public Slider slider;

    public Text topSayisi,goldTXT,kickUpgradeGoldTXT;

    public GameObject ttp;

    public GameObject gameOver;
    public GameObject ttpNext;

    public GameObject clickObj;
    public Slider clickSlider;

    public GameObject upgrades;
    
    void Start()
    {
        winParticle.SetActive(false);
        ttp.SetActive(true);
        gameOver.SetActive(false);
        ttpNext.SetActive(false);
        clickObj.SetActive(false);
        
        level = PlayerPrefs.GetInt("Level", 1);

        currentLevelText.text = level.ToString();
        nextLevelText.text = (level + 1).ToString();
        
    }

    private void Update()
    {
        slider.value = ((snowBall.position.z) -8) / ((10 + level) * 10) ;
        topSayisi.text = FindObjectOfType<ParcacikCreaterScript>().topSayisi.ToString();

        goldTXT.text = PlayerPrefs.GetInt("Gold").ToString();
        kickUpgradeGoldTXT.text = FindObjectOfType<GameManagerScript>().kickUpgradeGold.ToString();

        if (GameManagerScript.currentState == GameManagerScript.PlayerState.Preparing)
        {
            upgrades.SetActive(true);
        }
        else
        {
            upgrades.SetActive(false);
        }
        
        if (GameManagerScript.currentState == GameManagerScript.PlayerState.Death)
        {
            gameOver.SetActive(true);
        }
        
        if (GameManagerScript.currentState == GameManagerScript.PlayerState.Finish)
        {
            clickObj.SetActive(false);
            winParticle.SetActive(true);
            ttpNext.SetActive(true);
        }

        if (GameManagerScript.currentState == GameManagerScript.PlayerState.Shooting)
        {
            clickObj.SetActive(true);
        }
        else
        {
            clickObj.SetActive(false);
        }

        if (clickObj.active == true)
        {
            clickSlider.value = FindObjectOfType<ClickOAOScript>().sliderValue;
        }


    }

    public void tapToPlay()   
    {
        if (GameManagerScript.currentState == GameManagerScript.PlayerState.Preparing)
        {
            if (Input.GetMouseButtonUp(0))
            {
                GameManagerScript.currentState = GameManagerScript.PlayerState.Playing;
                ttp.SetActive(false);
            }
        }

    }


}
