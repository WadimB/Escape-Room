using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public Animator animator;
    public bool isOpen = false;
    public bool isOpen2 = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.O)){
            isOpen = !isOpen;
            animator.SetBool("isOpen", isOpen);
        }

    }

    //public void openDoor(){
    //        animator.SetBool("isOpen", true);        
    //}
}
