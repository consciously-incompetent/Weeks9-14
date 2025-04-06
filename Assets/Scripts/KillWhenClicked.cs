using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class KillWhenClicked : MonoBehaviour
{
    //variables

    //gets ahold of its own sprite renderd along with the script that created it 
    public SpriteRenderer sprite;
    public SpawnerOfObjects script;
    //for the amount the scroe should increase by when the prefab is clicked
    public float IncreaseAmount;
    
 
    void Update()
    {
        //gets the mouses positon and the objects own sprite
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        sprite = GetComponent<SpriteRenderer>();


        //then checks if the mosue is within the sprite and left is pressed
        if (sprite.bounds.Contains(mousePos) && Input.GetMouseButtonDown(0))
        {
            //increase the scpre the specified amount 
            script.score += IncreaseAmount;
            //and then it destroys itself
            Destroy(gameObject);

        }

        


    }
}
