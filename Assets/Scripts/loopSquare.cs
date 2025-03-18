using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loopSquare : MonoBehaviour
{
    public float t;
    public void grow()
    {
        //GetBigger();
        StartCoroutine(GetBigger());
    }

    // Update is called once per frame
    IEnumerator GetBigger()
    {
        t = 0;
        while (t < 1)
        {   
            t += Time.deltaTime;
            transform.localScale = Vector3.one * t;
            yield return null;
        }

        //transform.localScale = Vector3.one * t;

        
    }
}
