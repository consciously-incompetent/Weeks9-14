using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class timer : MonoBehaviour
{
    bool GameRun = true;
    public float t;
    public UnityEvent SpawnPieces;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawn());
    }


    IEnumerator StartSpawn()
    {
        while (GameRun)
        {
            t += Time.deltaTime;
            if(t > 5)
            {
                t = 0;
                Debug.Log("game be runnin");
                SpawnPieces.Invoke();
            }
            yield return null;
        }

    }




}
