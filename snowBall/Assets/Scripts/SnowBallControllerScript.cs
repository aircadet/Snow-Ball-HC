using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnowBallControllerScript : MonoBehaviour
{

    public GameObject snowBall;
    public Vector3 force;

    public Transform zemin;    

    Vector3 fark;

    Swipe swiper;

    float swiperX;
    Vector3 firstPos;
    float swipeFark;

    public float oran;

    public GameObject plane;

    private void Start()
    {
        swiper = GameObject.Find("Swipe").GetComponent<Swipe>();
        firstPos = snowBall.transform.position;
    }

    void Update()
    {
        snowBall.GetComponent<Rigidbody>().AddForce(force, ForceMode.Acceleration);
        snowBall.GetComponent<Rigidbody>().AddTorque(force, ForceMode.Acceleration);

        if (swiper.isDragging)
        {
            swiperX = swiper.SwipeDelta.x;

        }

        if (swiperX <= 0)
        {
            swipeFark =  firstPos.x + swiperX;
            snowBall.transform.position = new Vector3(((snowBall.transform.position.x + swipeFark) / oran), snowBall.transform.position.y, snowBall.transform.position.z);
        }
        else
        {
            swipeFark = firstPos.x - swiperX;
            snowBall.transform.position = new Vector3(((snowBall.transform.position.x - swipeFark) / oran), snowBall.transform.position.y, snowBall.transform.position.z);
        }

        

        

        if (snowBall.transform.position.x > plane.GetComponent<MeshRenderer>().bounds.max.x)
        {
            snowBall.transform.position = new Vector3(plane.GetComponent<MeshRenderer>().bounds.max.x-0.5f, snowBall.transform.position.y, snowBall.transform.position.z);
        }

        if (snowBall.transform.position.x < plane.GetComponent<MeshRenderer>().bounds.min.x)
        {
            snowBall.transform.position = new Vector3(plane.GetComponent<MeshRenderer>().bounds.min.x+0.5f, snowBall.transform.position.y, snowBall.transform.position.z);

        }

        if (snowBall.transform.position.y <= -5)        
        {
            SceneManager.LoadScene(0);
        }

     

    }

   
}
