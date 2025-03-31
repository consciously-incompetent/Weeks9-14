using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;

public class timer : MonoBehaviour
{
    bool GameRun = true;
    public float t;
    public UnityEvent SpawnPieces;
    Coroutine GameOn;


    // Start is called before the first frame update
    void Start()
    {
        GameOn = StartCoroutine(StartSpawn());
    }


    IEnumerator StartSpawn()
    {
        while (GameRun)
        {
            t += Time.deltaTime;
            if(t > 5)
            {
                t = 0;
                //Debug.Log("game be runnin");
                SpawnPieces.Invoke();
            }
            yield return null;
        }

    }



    public void WinGame()
    {
        //GetComponent<SpawnerOfObjects>().score = 
        if (GetComponent<SpawnerOfObjects>().score >= 100)
        {
            StopCoroutine(GameOn);
        }
        //StopAllCoroutines();
        
        
    }
}
