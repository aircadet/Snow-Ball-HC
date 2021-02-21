using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowBallControllerScript : MonoBehaviour
{

    public GameObject snowBall;
    public Vector3 force;

    public Transform zemin;

    

    Vector3 fark;

    private void Start()
    {
        /*hedef = new Vector3(snowBall.transform.position.x, snowBall.transform.position.y, snowBall.transform.position.z);*/
    }

    void Update()
    {
        

        if (Input.GetMouseButton(0) || Input.GetKey(KeyCode.UpArrow))
        {
            snowBall.GetComponent<Rigidbody>().AddForce(force, ForceMode.Acceleration);
            snowBall.GetComponent<Rigidbody>().AddTorque(force, ForceMode.Acceleration);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            snowBall.GetComponent<Rigidbody>().AddForce(new Vector3(0.5f, 0, 0), ForceMode.Impulse);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            snowBall.GetComponent<Rigidbody>().AddForce(new Vector3(-0.5f, 0, 0), ForceMode.Impulse);
        }

    }

   
}
