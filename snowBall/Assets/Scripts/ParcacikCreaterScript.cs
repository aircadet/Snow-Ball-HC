using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParcacikCreaterScript : MonoBehaviour
{
    public GameObject parcacik;
    public int topSayisi;
    int sayi = 0;

    GameObject obstacles;

    int level;
    float minZ = 15;
    float maxZ = 30;

    float sphereCount;

    void Start()
    {
        level = PlayerPrefs.GetInt("Level");
        sphereCount = (level + 10) / 2;

        while (sayi <sphereCount)
        {
            float x = Random.Range(-4, 4);
            float z = Random.Range(minZ, maxZ);
            Vector3 pos = new Vector3(x, .37f, z);
            Quaternion rot = new Quaternion(0, 0, 0, 0);

            obstacles = Instantiate(parcacik, pos, rot);

            sayi++;

            obstacles.transform.parent = GameObject.Find("Parcaciklar").transform;

            minZ += ((level + 10) * 10) / sphereCount;
            maxZ += ((level + 10) * 10) / sphereCount;

        }

    }
}
