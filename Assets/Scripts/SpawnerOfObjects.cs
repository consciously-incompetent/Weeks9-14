using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SpawnerOfObjects : MonoBehaviour
{
    //variables


    //for the score tracking
    public float score;
    //for the pawn bishop and knight prefabs
    public GameObject pawn;
    public GameObject bishop;
    public GameObject rook;
    // to get ahold of the timer scripts
    public timer timerScript;
    //for the UI element that shows the player the score
    public TextMeshProUGUI scoreTracker;


    private void Start()
    {
        //at the start of the game one pawn is added to the unity even so that game is playable
        timerScript.SpawnPieces.AddListener(PawnSpawn);

    }

    private void Update()
    {
        //constantly updating the score tracker's text element to display the current score
        scoreTracker.text = score.ToString();
    }

    public void PawnSpawn()
    {
        //the function that spawns a fresh pawn from the prefabs 
        //its then given this script along with how much it should increase the score by when its clicked 
        // for the pawn that is 3
        //then its sent to  random position inside a unite circle

        GameObject newPawn = Instantiate(pawn);
        newPawn.GetComponent<KillWhenClicked>().script = this;
        newPawn.GetComponent<KillWhenClicked>().IncreaseAmount = 3;
        newPawn.transform.position = Random.insideUnitCircle * 4;
        
        
        

    }

    public void BishopSpawn()
    {

        //the function that spawns a fresh bishop from the prefabs 
        //its then given this script along with how much it should increase the score by when its clicked 
        // for the bishop that is 5
        //then its sent to  random position inside a unite circle
        GameObject newBishop = Instantiate(bishop);
        newBishop.GetComponent<KillWhenClicked>().script = this;
        newBishop.GetComponent<KillWhenClicked>().IncreaseAmount = 5;
        newBishop.transform.position = Random.insideUnitCircle * 4;
    }

    public void RookSpawn()
    {
        //the function that spawns a fresh rook from the prefabs 
        //its then given this script along with how much it should increase the score by when its clicked 
        // for the rook that is 10
        //then its sent to  random position inside a unite circle
        GameObject newRook = Instantiate(rook);
        newRook.GetComponent<KillWhenClicked>().script = this;
        newRook.GetComponent<KillWhenClicked>().IncreaseAmount = 10;
        newRook.transform.position = Random.insideUnitCircle * 4;
    }


    public void addPawn()
    {
        // this function will be called by clicking the add pawn button 
        if(score >= 15)
        {
            score -= 15;
            // so you can only purchase upgrades if you have enough score

            //then the function that spawns the pawn prefab is added the listener
            timerScript.SpawnPieces.AddListener(PawnSpawn);
        }
    }


    // this code is the same as the above but for the bishop and rook instead of the pawn
    public void addBishop()
    {
        if(score >= 30)
        {
            score -= 30;
            timerScript.SpawnPieces.AddListener(BishopSpawn);
        }
        
    }

    public void addRook()
    {
        if (score >= 60)
        {
            score -= 60;
            timerScript.SpawnPieces.AddListener(RookSpawn);

        }
    }

   // public void WinGame()
   // {
  //      StopAllCoroutines();
    ///}
    ///// just testing for coroutines and ending the game 



}
