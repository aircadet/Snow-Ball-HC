using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishScript : MonoBehaviour
{
    public Transform player;
    bool isCollide = false;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "snowBall" && !isCollide)        
        {
            GameManagerScript.currentState = GameManagerScript.PlayerState.Shooting;
            FindObjectOfType<PlayerPosScript>().isFinished = true;
            FindObjectOfType<CameraContollerScript>().hedef = player;
            isCollide = true;

        }
    }

    IEnumerator wait(float time)
    {
        yield return new WaitForSeconds(time);
    }


}
