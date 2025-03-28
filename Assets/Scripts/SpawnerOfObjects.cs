using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerOfObjects : MonoBehaviour
{
    public float score;
    public GameObject pawn;
    public GameObject bishop;
    public GameObject rook;
    public timer timerScript;


    private void Start()
    {
        //timerScript = GetComponent<timer>();
        //i thought i understood GetComponent but the above code is unnacesary 
        timerScript.SpawnPieces.AddListener(PawnSpawn);

    }


    public void PawnSpawn()
    {
        //Instantiate(pawn);

        GameObject newPawn = Instantiate(pawn);
        newPawn.GetComponent<KillWhenClicked>().script = this;
        newPawn.GetComponent<KillWhenClicked>().IncreaseAmount = 3;
        newPawn.transform.position = Random.insideUnitCircle * 5;
        
        
        

    }

    public void BishopSpawn()
    {
        GameObject newBishop = Instantiate(pawn);
        newBishop.GetComponent<KillWhenClicked>().script = this;
        newBishop.GetComponent<KillWhenClicked>().IncreaseAmount = 5;
        newBishop.transform.position = Random.insideUnitCircle * 5;
    }

    public void RookSpawn()
    {
        GameObject newRook = Instantiate(pawn);
        newRook.GetComponent<KillWhenClicked>().script = this;
        newRook.GetComponent<KillWhenClicked>().IncreaseAmount = 10;
        newRook.transform.position = Random.insideUnitCircle * 5;
    }




}
