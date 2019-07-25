using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowAnim : MonoBehaviour
{
    public bool slidingDown = false;
    //priavte variables
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Space) && animator.GetBool("SlidingDown") == false)
         {
             animator.SetBool("SlidingDown", true);
            print("yaas");
         }

         else if (Input.GetKeyDown(KeyCode.Space) && animator.GetBool("SlidingDown") == true)
         {
             animator.SetBool("SlidingDown", false);
         }

        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            if (animator.GetBool("SlidingDown") == false && animator.GetBool("SlidingUp") == true)
            {
                animator.SetBool("SlidingDown", true);
                animator.SetBool("SlidingUp", false);
            }
            if (animator.GetBool("SlidingDown") == true && animator.GetBool("SlidingUp") == false)
            {
                animator.SetBool("SlidingDown", false);
                animator.SetBool("SlidingUp", true);
            }
        }*/


    }
}
