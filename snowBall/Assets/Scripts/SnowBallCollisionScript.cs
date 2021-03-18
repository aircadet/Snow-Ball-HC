using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallCollisionScript : MonoBehaviour
{
    public bool isHit;
    private void Update()
    {
        Debug.Log("PlayerState ---->" + GameManagerScript.currentState);
        isHit = FindObjectOfType<PlayerControllerScript>().isHit;
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (isHit)
        {
            GameManagerScript.currentState = GameManagerScript.PlayerState.Finish;
        }
    }


}
