using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunHero : MonoBehaviour
{
    SpriteRenderer SR;
    Animator animator;
    public moveWhenclick script;
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        script = GetComponent<moveWhenclick>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(script.moving)
        {
            // i need this to change the hero to a running script but i can't figure it out 
        }
    }
}
