using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "snowBall")        
        {
            FindObjectOfType<MapCreaterScript>().isFinished = true;            
        }
    }

    
}
