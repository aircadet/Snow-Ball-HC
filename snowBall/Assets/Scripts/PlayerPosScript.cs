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
    
    void Update()
    {
        if (!isFinished)
        {
            player.position = new Vector3(snowBall.position.x, snowBall.GetComponent<MeshRenderer>().bounds.max.y, snowBall.position.z);
        }
        else if (isFinished && !test)
        {
            Vector3 toPos = new Vector3(snowBall.position.x, snowBall.GetComponent<MeshRenderer>().bounds.min.y, snowBall.position.z - 2);
            player.position = Vector3.Lerp(player.position,toPos,1);
            test = true;
            Camera.main.transform.rotation = Quaternion.Euler(30, 0, 0);

        }

        if (test && !test2)
        {
            StartCoroutine(Wait(1));
            test = true;
            
        }



    }

    IEnumerator Wait(float time)
    {
        yield return new WaitForSeconds(time);
        Time.timeScale = .5f;
        player.GetComponent<Rigidbody>().AddForce(new Vector3(0,0,5));
    }

        
}
