using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "snowBall")
        {
            Destroy(gameObject);
            FindObjectOfType<ParcacikCreaterScript>().topSayisi--;
            
            GameObject.FindGameObjectWithTag("snowBall").transform.localScale -= new Vector3(.2f, .2f, .2f);
        }
    }
}
