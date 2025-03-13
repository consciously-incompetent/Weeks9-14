using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;



public class whenMouseClicked : MonoBehaviour
{
    public UnityEvent OnLeftMouse;
    public UnityEvent OnRightMouse;

 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            OnLeftMouse.Invoke();
        }

        if (Input.GetMouseButtonDown(1))
        {
            OnRightMouse.Invoke();
        }


    }
}
