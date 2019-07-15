using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchThrow : MonoBehaviour
{
    public GameObject torch;
    public GameObject torchClone;
    public float throwForce;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ThrowTorch()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 directionToMouse = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = directionToMouse;
        torchClone = Instantiate(torch, transform.position ,Quaternion.Euler(0,0,0));

        torchClone.GetComponent<Rigidbody2D>().AddForce(transform.up * throwForce);
        torchClone.transform.parent = null;
    }

}
