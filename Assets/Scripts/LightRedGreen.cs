using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRedGreen : MonoBehaviour
{
    // Start is called before the first frame update
    public Color red;
    public Color green;
    public SpriteRenderer LightColour;



    public void setGreen()
    {
        LightColour.color = green;
    }


    public void setRed()
    {
        LightColour.color = red;
    }

}
