using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    bool GameRun = true;
    public float t;
    public UnityEvent SpawnPieces;
    public Slider slider;

  
    public GameObject UIelement_upgrade_1;
    public GameObject UIelement_upgrade_2;
    public GameObject UIelement_upgrade_3;
    public GameObject UIelement_win;
    public GameObject UIelement_winText;
    public GameObject UIelement_score_1;
    public GameObject UIelement_score_2;


    public GameObject TimerImage;

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
            slider.value = t;
            
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


            TimerImage.SetActive(false);
            UIelement_upgrade_1.SetActive(false);
            UIelement_upgrade_2.SetActive(false);
            UIelement_upgrade_3.SetActive(false);
            UIelement_win.SetActive(false);
            UIelement_score_1.SetActive(false);
            UIelement_score_2.SetActive(false);
            UIelement_winText.SetActive(true);


    StopCoroutine(GameOn);




        }
        //StopAllCoroutines();
        
        
    }
}
