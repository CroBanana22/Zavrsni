using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchRotation : MonoBehaviour
{
    public float rotationSpeed;
    public Transform fire;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        fire = this.gameObject.transform.GetChild(0);
        Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(this.GetComponent<Collider2D>(), player.GetComponent<CircleCollider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime);
        
    }
}
