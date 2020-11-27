using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    
    public float runSpeed = 40f;
    
    float horizontalMove = 0f;
    System.Boolean jump = false;
    
    // Update is called once per frame
    void Update(){
        
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
        
        if(Input.GetButtonDown("Jump")){
            jump = true;
        }
        
        if(transform.position.x<=-8.4f)
        {
            transform.position = new Vector3(-8.4f, transform.position.y, 0);
        }
        if(transform.position.x>=8.4f)
        {
            transform.position = new Vector3(8.4f, transform.position.y, 0);
        }
        if(transform.position.y>=44)
        {
            transform.position = new Vector3(transform.position.x, 44, 0);
        }
    }
    
    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump =false;
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }
        
}
