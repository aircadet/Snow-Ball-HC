using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SnowBallControllerScript : MonoBehaviour
{

    public GameObject snowBall;
    public Vector3 force;
    public Transform zemin;    
    Swipe swiper;
    float swiperX;
    Vector3 firstPos;
    float swipeFark;
    public float oran;
    public GameObject plane;
    public GameObject player;


    private void Start()
    {
        swiper = GameObject.Find("Swipe").GetComponent<Swipe>();
        
    }

    void Update()
    {
        if (GameManagerScript.currentState == GameManagerScript.PlayerState.Playing)
        {
            snowBall.GetComponent<Rigidbody>().AddForce(force, ForceMode.Acceleration);


            if (swiper.isDragging)
            {
                firstPos = snowBall.transform.position;
                swiperX = swiper.SwipeDelta.x;

                if (swiperX <= 0)
                {

                    swipeFark = 0 + swiperX;
                    snowBall.transform.position = new Vector3(Mathf.Clamp(((firstPos.x + swipeFark) / oran), -4.10f, 4.10f), snowBall.transform.position.y, snowBall.transform.position.z);
                }
                else
                {
                    firstPos = snowBall.transform.position;
                    swipeFark = 0 - swiperX;

                    snowBall.transform.position = new Vector3(Mathf.Clamp(((firstPos.x - swipeFark) / oran), -4.10f, 4.10f), snowBall.transform.position.y, snowBall.transform.position.z);

                }
            }
            else
            {
                firstPos = snowBall.transform.position;
            }

            if (snowBall.transform.position.y <= -5 || player.transform.position.y <= -5)
            {
                SceneManager.LoadScene(0);
            }

        }
    }

    
}
