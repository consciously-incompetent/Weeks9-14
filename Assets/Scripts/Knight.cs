
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Knight : MonoBehaviour
{
    SpriteRenderer SR;
    Animator animator;
    public float speed = 4;
    public bool canRun = true;
    public List<AudioClip> StepSounds;
   
    public AudioSource Step;

    void Start()
    {
        SR = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        float direction = Input.GetAxisRaw("Horizontal");

        SR.flipX = direction < 0;

        animator.SetFloat("movement", Mathf.Abs(direction));

        if (Input.GetMouseButtonDown(0))
        {
            
            animator.SetTrigger("attack");
            canRun = false;
        }


        if (canRun == true)
        {
            transform.position += transform.right * direction * speed * Time.deltaTime;
        }
        

    }



    public void AttackHasFinished()
    {
        canRun = true;
    }

    public void StepSound()
    {
        Debug.Log("step");
        Step.PlayOneShot(StepSounds[Random.Range(0,StepSounds.Count)]);
    }



}
