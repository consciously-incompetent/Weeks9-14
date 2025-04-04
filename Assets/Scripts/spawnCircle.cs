using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCircle : MonoBehaviour
{
    public float t;
    public GameObject triangle;
    public float points;


    // Start is called before the first frame update
    void Start()
    {
        while(t < 5)
        {
            GameObject newTriangle = Instantiate(triangle);
            //newTriangle.GetComponent<KillWhenClicked>().script = this;
            newTriangle.transform.position = Random.insideUnitCircle * 4;
            t += 1;
        }
        
    }

    



}
