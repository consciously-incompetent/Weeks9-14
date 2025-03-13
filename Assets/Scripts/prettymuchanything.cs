using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class prettymuchanything : MonoBehaviour
{
    public RectTransform banana;
    public UnityEvent OnTimerEnd;
    public float TimerLength = 3;
    public float t;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if(t > TimerLength)
        {
            t = 0;
            OnTimerEnd.Invoke();
        }
    }

    public void MouseEntering()
    {
        banana.localScale = Vector3.one * 1.2f;
    }
    


    public void MouseLeaving()
    {
        banana.localScale = Vector3.one * 1f;
    }

        
    
}
