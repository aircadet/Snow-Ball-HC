using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapCreaterScript : MonoBehaviour
{
    public GameObject zemin;
    public GameObject finish;
   
    public int uzunluk;   
    private int uzunluk2 = 0;

    private Vector3 pos = new Vector3(0, 0, 20);
    private Quaternion rot = new Quaternion(0, 0, 0, 0);
    
    private GameObject deneme;

    private int level;

    public bool isFinished = false;

    private void Start()
    {
        level = PlayerPrefs.GetInt("Level", 1);
        Debug.Log("Level -->" + level);
        uzunluk = 10 + level;
        while (uzunluk2 <= uzunluk)
        {
            
            deneme = Instantiate(zemin, pos, rot);
            uzunluk2 += 1;
            pos += new Vector3(0, 0, 10);

            deneme.transform.parent = GameObject.Find("Zemin").transform;
        }

        deneme = Instantiate(finish, pos, rot);
        deneme.transform.parent = GameObject.Find("Zemin").transform;

    }

    private void Update()
    {
        if (isFinished)       
        {
            PlayerPrefs.SetInt("Level", level + 1);
            SceneManager.LoadScene(0);
        }
    }
}
