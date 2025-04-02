using UnityEngine;

public class teachersController : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    Animator animator;  

    void Start()
    {
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        //when you press a certain thing ** that will have you test it
        if(Input.GetKeyDown(KeyCode.T)){
            //call the transition to pose function
            transitionToPose();
        }


    }

    public void transitionToPose() //this function will transition the teacher to 
    {
        //this will go reference the animator for the given object to Gabriella and have her boolean set to true
        animator.SetBool("poseBool", true);

    }
}
