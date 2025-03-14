using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Growth : MonoBehaviour
{
    public AnimationCurve curve;
    public float minSize = 0;
    public float maxSize = 1;
    public float t;
    public bool startGrow; 

    // Update is called once per frame

    private void Update()
    {
       

        if (startGrow)
        {
            grow();
        }

    }

    public void startGrowing()
    {
        startGrow = true;
        t = 0;
    }

    private void grow()
    {

       
        if (t < 1)
        {
            t += Time.deltaTime;
        }
        else
        {
            startGrow = false;
            //t = 0;
        }




        transform.localScale = Vector3.one * maxSize * curve.Evaluate(t);
        //transform.localScale = Vector3.Lerp(Vector3.one * minSize, Vector3.one * maxSize, curve.Evaluate(t));



    }
}
