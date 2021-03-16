using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControllerScript : MonoBehaviour
{
    public GameObject player;
    public Vector3 hitSpeed = new Vector3(0, 3, 10);

    public bool isHit = false;

    public Vector3 speed = new Vector3(0,0,5);

    float sliderValue;

    private void Update()
    {
        if (GameManagerScript.currentState == GameManagerScript.PlayerState.Shooting)
        {         
               player.GetComponent<Rigidbody>().AddForce(speed,ForceMode.Acceleration);
               sliderValue = FindObjectOfType<ClickOAOScript>().currentValue;
        }
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (GameManagerScript.currentState == GameManagerScript.PlayerState.Shooting)
        {
            if (collision.transform.tag == "snowBall" && !isHit)
            {
                Time.timeScale = 1;
                collision.gameObject.GetComponent<Rigidbody>().AddForce(hitSpeed * sliderValue, ForceMode.Impulse);
                player.GetComponent<Rigidbody>().isKinematic = true;

                Debug.Log("Vurdu ----->" + sliderValue * hitSpeed);
                isHit = true;

            }
        }
    }


}
