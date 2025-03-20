using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.Events;

public class KitClock : MonoBehaviour
{
    public float timeAnHourTakes = 5;
    public Transform hourHand;
    public Transform minuteHand;
    public float t;
    public int hour = 0;

    public UnityEvent OnTheHour;

    private void Start()
    {
        StartCoroutine(MoveTheClock());
    }

    IEnumerator MoveTheClock()
    {
        while(true)
        {
            yield return StartCoroutine(MoveTheClockHands1Hour());
        }
        
        
    }


    IEnumerator MoveTheClockHands1Hour()
    {
        t = 0;
        while (t < timeAnHourTakes)
        {
            
            t += Time.deltaTime;
            minuteHand.Rotate(0, 0, -(360 / timeAnHourTakes) * Time.deltaTime);
            hourHand.Rotate(0, 0, -(30 / timeAnHourTakes) * Time.deltaTime);
            yield return null; 
        }
        OnTheHour.Invoke();
    }
}
