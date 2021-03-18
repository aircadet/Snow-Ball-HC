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

    int minZ = 15, maxZ = 15;

    int topZ;

    public Material obs1, obs2, obs3, sphere,wallMaterial;

   
    void Start()
    {
        topZ = (PlayerPrefs.GetInt("Level")+10)*10 ;

        BuildObsNumber();
        ObstacleColoring();
       
        while (obstacle < totalObstacle)
        {
            float x = 0;
            float y = .8f;
            float z = Random.Range(minZ,maxZ);

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

            if (maxZ >= topZ)
            {
                maxZ = topZ;
            }
            else
            {
                
                minZ += topZ / totalObstacle;
                maxZ += topZ / totalObstacle;
            }
            
        }
        
    }

    void BuildObsNumber()
    {
        if (PlayerPrefs.GetInt("Level") <= 15)
        {
            totalObstacle = PlayerPrefs.GetInt("Level");
        }
        else if (PlayerPrefs.GetInt("Level") > 15 && PlayerPrefs.GetInt("Level") <= 30)
        {
            totalObstacle = PlayerPrefs.GetInt("Level") - 5;
        }
        else
        {
            totalObstacle = PlayerPrefs.GetInt("Level") - 15;
        }
    }

    void ObstacleColoring()
    {
        obs1.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        obs2.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        obs3.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        sphere.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

        wallMaterial.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);

    }



}
