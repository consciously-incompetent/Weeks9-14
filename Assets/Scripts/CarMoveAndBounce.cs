using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoveAndBounce : MonoBehaviour
{

    float speed = 5f;
    float PastSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos); 

        pos.x += speed * Time.deltaTime;

        if(screenPos.x < 0)
        {
            speed *= -1;
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(0, 0)).x;
        }

        if(screenPos.x > Screen.width)
        {
            speed *= -1;
            pos.x = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x;
        }





        transform.position = pos;


    }

    public void Stop()
    {
        PastSpeed = speed;
        speed = 0;
    }

    public void Go()
    {
        speed = PastSpeed;
    }

}
