using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParcacikScript : MonoBehaviour
{
    public GameObject snowBall;
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "snowBall")
        {
            FindObjectOfType<ParcacikCreaterScript>().topSayisi+=2;
            snowBall.transform.localScale += new Vector3(.3f, .3f, .3f);
            Destroy(gameObject);
        }
    }
}
