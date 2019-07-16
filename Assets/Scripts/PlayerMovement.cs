using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed ;
    public float jumpForce;
    public bool sprint=false;
    public static bool isGrounded = true;
    public bool isGroundedCheck;
    public bool jump = false;

    private Rigidbody2D rb;

    Vector3 horizontalMove ;
    float horizontalMoveRB;


    //za bacanje baklje
    public GameObject torchThrowPoint;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    //samo za player input 
    private void Update()
    {
        
        //Debug.Log(isGrounded);
        // kretanje ljevo desno horizontal move
        horizontalMove = new Vector3(Input.GetAxis("Horizontal"),0f,0f);
        horizontalMoveRB = Input.GetAxis("Horizontal");

        //sprintanje
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprint = true;
        }
        else if(Input.GetKeyUp(KeyCode.LeftShift))
        {
            sprint = false;
        }

        //skakanje
        if (Input.GetKeyDown(KeyCode.W))
        {
            jump = true;
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            jump = false;
        }
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            torchThrowPoint.GetComponent<TorchThrow>().ThrowTorch();
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            torchThrowPoint.GetComponent<TorchThrow>().ThrowRope();
        }



    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //isGroundedCheck = isGrounded;
        //Debug.Log(horizontalMoveRB);
        //Debug.Log(horizontalMove);
        //pokretanje ljevo desno A, D
        if(horizontalMove.x < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
        }else if(horizontalMove.x > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
        }
        //sprintanje
        if (sprint)
        {
            rb.velocity = new Vector2(horizontalMoveRB * (movementSpeed*1.5f), rb.velocity.y);
        }
        else
            //transform.position += movementSpeed * Time.deltaTime * horizontalMove;
            rb.velocity = new Vector2(horizontalMoveRB * movementSpeed  ,rb.velocity.y);

        if(jump && isGrounded)
        {
            rb.velocity = Vector2.up * jumpForce;
            jump = false;
        }


        #region test
        /*
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Debug.Log("shift has beed pressed");
                transform.position += (movementSpeed * 2f) * Time.deltaTime * move;

            }else transform.position += movementSpeed * Time.deltaTime * move;
        }
        */
        /*
        else if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
        transform.position += movementSpeed * Time.deltaTime * move;
        */
        #endregion
    }

    #region torch throw test
    //torch throw
    /*
    void ThrowTorch()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 directionToMouse = new Vector2(mousePosition.x = transform.position.x, mousePosition.y = transform.position.y);
        torchClone = Instantiate(torch, transform);
        
        torchClone.GetComponent<Rigidbody2D>().AddForce (transform.forward *2f);
        torchClone.transform.parent = null;
    }
    */
    #endregion
}
