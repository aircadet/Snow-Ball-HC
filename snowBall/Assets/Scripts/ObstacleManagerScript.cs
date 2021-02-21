using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManagerScript : MonoBehaviour
{
    public GameObject[] obstacles;
    public GameObject snowBall;

    int totalObstacle = 0;
    int obstacle;

    public Vector3 pos;
    Quaternion rot = new Quaternion(0, 0, 0, 0);

    GameObject obs;

    int zRange;

    void Start()
    {
        //LEVEL + 2 ADET ENGEL OLUŞTURMAYI SONRADAN EKLE//

        totalObstacle = PlayerPrefs.GetInt("Level") + 2;
        zRange = (PlayerPrefs.GetInt("Level") + 10) * 9;

        while (obstacle < totalObstacle)
        {
            float x = 0;
            float y = 0.5f;
            float z = Random.Range(15,zRange);

            Vector3 pos = new Vector3(x, y, z);
            if (obstacle < 2)
            {
                obs = Instantiate(obstacles[Random.Range(0, 1)], pos, rot);
                obs.transform.parent = GameObject.Find("Obstacles").transform;
                obstacle++;

                
            }
            else
            {
                obs = Instantiate(obstacles[Random.Range(0, 2)], pos, rot);
                obs.transform.parent = GameObject.Find("Obstacles").transform;
                obstacle++;
            }
        }


        
    }

    void Update()
    {
        
    }
}
