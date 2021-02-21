using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPosScript : MonoBehaviour
{
    public Transform snowBall;
    public Transform player;

    
    void Update()
    {
        player.position = new Vector3(snowBall.position.x, snowBall.GetComponent<MeshRenderer>().bounds.max.y,snowBall.position.z);
    }
}
