using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{
    private int level;

    public Transform snowBall;

    public Image currentLevelIMG;
    public Text currentLevelText;

    public Image nextLevelIMG;
    public Text nextLevelText;

    public Slider slider;

    public Text topSayisi;

    
    
    void Start()
    {
        
        level = PlayerPrefs.GetInt("Level", 1);

        currentLevelText.text = level.ToString();
        nextLevelText.text = (level + 1).ToString();
        
    }

    private void Update()
    {
        slider.value = ((snowBall.position.z) -8) / ((10 + level) * 10) ;
        topSayisi.text = FindObjectOfType<ParcacikCreaterScript>().topSayisi.ToString();
    }


}
