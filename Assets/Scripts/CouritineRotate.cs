using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class CouritineRotate : MonoBehaviour
{

    public AnimationCurve curve;
    public Button button;
    public float t;

    // Start is called before the first frame update
    public void Fight()
    {
        StartCoroutine(swing());
    }

  IEnumerator swing()
    {
        button.interactable = false;

        t = 0;

        while(t < 2)
        {
            t += Time.deltaTime;
            //transform.eulerAngles = Vector3.one * 90 * curve.Evaluate(t);
            transform.Rotate(0, 0, curve.Evaluate(t));
            yield return null;
        }

        t = 0;
        while(t < 1)
        {
            t += Time.deltaTime;
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.identity, t/25);
            yield return null;
        }
        button.interactable = true;
    }
}
