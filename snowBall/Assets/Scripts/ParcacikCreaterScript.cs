using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParcacikCreaterScript : MonoBehaviour
{
    public GameObject parcacik;
    public int topSayisi;
    int sayi = 0;

    Swipe swiper;

    GameObject obstacles;

     int level;

    void Start()
    {
        level = (PlayerPrefs.GetInt("Level") + 10) * 9;

        while (sayi <= 10)
        {
            float x = Random.Range(-4, 4);
            float z = Random.Range(15, level);
            Vector3 konum = new Vector3(x, 1, z);
            Quaternion rot = new Quaternion(0, 0, 0, 0);

            obstacles = Instantiate(parcacik, konum, rot);

            sayi++;

            obstacles.transform.parent = GameObject.Find("Parcaciklar").transform;

        }

    }
}
