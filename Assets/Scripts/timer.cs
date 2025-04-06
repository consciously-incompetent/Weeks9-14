using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    //variables 

    // a bool is made for the coroutine to run 
    //techincally unnecessary
    bool GameRun = true;
    //for the time tracking, the untiy even will be invoked every 5 seconds
    public float t;
    //for the untiy event
    public UnityEvent SpawnPieces;
    //for the timer that tracks when the next untiy event will be caled
    public Slider slider;

  // all the UI elements are put into game object variables so they can be turned off
    public GameObject UIelement_upgrade_1;
    public GameObject UIelement_upgrade_2;
    public GameObject UIelement_upgrade_3;
    public GameObject UIelement_win;
    public GameObject UIelement_winText;
    public GameObject UIelement_score_1;
    public GameObject UIelement_score_2;
    public GameObject TimerImage;

    // so i can store the coroutine in a variable that I can then turn off
    Coroutine GameOn;


    void Start()
    {
        
        GameOn = StartCoroutine(StartSpawn());
        //at the start of the game I start the coroutine and assign it the GameOn variable

    }


    IEnumerator StartSpawn()
    {
        //a while loop allows the coroutine to run forever until I stop it 
        while (GameRun)
        {
            // every frame time is increased by time and the slider is in increase by time
            //the slider is the UI element that shows the player the time until next unity event is invoked 
            t += Time.deltaTime;
            slider.value = t;
            
            //an if statement that triggers every 5 seconds
            if(t > 5)
            {
                //resets the timer back to 0
                t = 0;
                //Debug.Log("game be runnin");
                //calls the untiy event that spawns the pieces
                SpawnPieces.Invoke();
            }
            // a bit of code that tells the coroutine to come back next frame 
            yield return null;
        }

    }


    // a function thats set to one of my buttons that lets the player 'win' the gaem if they have 100 or more score
    public void WinGame()
    {
        //GetComponent<SpawnerOfObjects>().score = 
        if (GetComponent<SpawnerOfObjects>().score >= 100)
        {//checking if scroe is 100 or more

            //setting all the UI elements to false so they disapear
            TimerImage.SetActive(false);
            UIelement_upgrade_1.SetActive(false);
            UIelement_upgrade_2.SetActive(false);
            UIelement_upgrade_3.SetActive(false);
            UIelement_win.SetActive(false);
            UIelement_score_1.SetActive(false);
            UIelement_score_2.SetActive(false);
            //setting the winning text to true so it displays
            UIelement_winText.SetActive(true);

            //and then finally it stop the coroutine so no more pieces can spawn
    StopCoroutine(GameOn);




        }
        //StopAllCoroutines();
        
        
    }
}
