using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraContollerScript : MonoBehaviour
{
    public Transform hedef;
    public Vector3 takipMesafe;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, hedef.position - takipMesafe, .5f);
    }
}
