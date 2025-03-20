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

    public UnityEvent<int> OnTheHour;


    Coroutine ClockIsRunning;
    IEnumerator DoOneHour;

    private void Start()
    {
        ClockIsRunning = StartCoroutine(MoveTheClock());
    }

    IEnumerator MoveTheClock()
    {
        while(true)
        {

            DoOneHour = MoveTheClockHands1Hour();
            yield return StartCoroutine(DoOneHour);
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
        hour++;
        if(hour == 13)
        {
            hour = 1;
        }
        OnTheHour.Invoke(hour);
    }


    public void StopTheClock()
    {
        if(ClockIsRunning != null)
        {
            StopCoroutine(ClockIsRunning);
        }


        if(DoOneHour != null)
        {
            StopCoroutine(DoOneHour);
        }

    }
}
