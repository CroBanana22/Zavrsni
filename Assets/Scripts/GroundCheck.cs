using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GroundCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D ground)
    {
        if(ground.tag == "Ground")
        {
            PlayerMovement.isGrounded = true;
        }
    }

    private void OnTriggerStay2D(Collider2D ground)
    {
        if (ground.tag == "Ground")
        {
            PlayerMovement.isGrounded = true;
        }
    }

    private void OnTriggerExit2D(Collider2D ground)
    {
        if (ground.tag == "Ground")
        {
            PlayerMovement.isGrounded = false;
        }
        
    }
}
