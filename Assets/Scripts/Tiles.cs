using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Tiles : MonoBehaviour
{
    public Tilemap Tilemap;
    public Tile grass;
    public Tile stone ;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos =  Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector3Int gridPos =  Tilemap.WorldToCell(mousePos);

            Debug.Log(gridPos);

            if(Tilemap.GetTile(gridPos) == stone)
            {
                Tilemap.SetTile(gridPos, grass);
            }
            else
            {
                Tilemap.SetTile(gridPos, stone );
            }
        }
    }
}
