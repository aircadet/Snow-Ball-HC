using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosScript : MonoBehaviour
{
    public Transform snowBall;
    public Transform player;


    public bool isFinished = false;

    bool test = false;
    bool test2 = false;
    public bool isJumped = false;

    public Vector3 playerJumpSpeed = new Vector3(0, 5, -25);
    public Vector3 snowBallJumpSpeed = new Vector3(0, 0, 15);


    void Update()
    {
        if (!isFinished)
        {
            player.position = new Vector3(snowBall.position.x, snowBall.GetComponent<MeshRenderer>().bounds.max.y, snowBall.position.z);
        }
        else if (isFinished && !test)
        {
            player.GetComponent<Rigidbody>().AddForce(playerJumpSpeed, ForceMode.Impulse);
            
            Camera.main.transform.rotation = Quaternion.Euler(30, 0, 0);
            snowBall.GetComponent<Rigidbody>().AddForce(snowBallJumpSpeed, ForceMode.Impulse);

            isJumped = true;

            test = true;

        }

        if (test && !test2)
        {
            StartCoroutine(Wait(.5f));
            test2 = true;
            
        }

    }

    IEnumerator Wait(float time)
    {
        yield return new WaitForSeconds(time);
        Time.timeScale = .5f;
        
    }

}
