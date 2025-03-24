using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class KillWhenClicked : MonoBehaviour
{
    public SpriteRenderer sprite;
    public spawnCircle script;
 
    void Update()
    {
        
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        sprite = GetComponent<SpriteRenderer>();

        if (sprite.bounds.Contains(mousePos) && Input.GetMouseButtonDown(0))
        {
            //pos.x += 5;
            script.points += 3;
            Destroy(gameObject);

        }

        


    }
}
