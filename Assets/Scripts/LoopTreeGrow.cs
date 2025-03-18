using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class LoopTreeGrow : MonoBehaviour
{
    public float t;
    float maxSize = 1;
    public AnimationCurve curve;


    public void StartGrowing()
    {
        StartCoroutine(Grow());
    }


    IEnumerator Grow()
    {
        t = 0;
        while(t < 1)
        {
            t += Time.deltaTime;
            transform.localScale = Vector3.one * maxSize * curve.Evaluate(t);
            yield return null;
        }
    }




}
