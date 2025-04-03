using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class moveWhenclick : MonoBehaviour
{
    public Tilemap tilemap;
    public Tile grass;
    public Tile stone;
    public bool moving = false;
    float t;


    // Update is called once per frame
    void Update()
    {
        //t += Time.deltaTime;
        //Vector2 lastPos = Vector2.zero;
        //Vector2 currentPos = Vector2.zero;

        if (Input.GetMouseButtonDown(0))
        {


            Vector2 currentPos = transform.position;
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3Int GridPos = tilemap.WorldToCell(mousePos);

            if(tilemap.GetTile(GridPos) != grass && !moving)
            {              
                StartCoroutine(Move(currentPos, mousePos));

            }

        }

    }



    public IEnumerator Move(Vector2 currentPosCO, Vector2 lastPosCO)
    {
        moving = true;

        while(t < 1)
        {
            t += Time.deltaTime;
            transform.position = Vector2.Lerp(currentPosCO, lastPosCO, t);
            yield return null;
        }
        t = 0;
        moving = false;


    }


}
