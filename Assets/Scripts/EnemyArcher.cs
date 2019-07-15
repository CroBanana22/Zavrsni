using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyArcher : MonoBehaviour
{
    public GameObject player;
    public Ray detectionRay;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        
        detectionRay = new Ray(transform.position, new Vector2(player.transform.position.x, player.transform.position.y));
        Vector2 originRay = transform.position;
        Debug.DrawRay(transform.position, player.transform.position, Color.red);
       // return Physics2D.Raycast(transform.position, player.transform.position);
    }

    
}
