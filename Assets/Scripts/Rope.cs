using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rope : MonoBehaviour
{
    public float distance = 2f;
    private GameObject player;
    public GameObject jointDot;
    public GameObject jointDotClone;
    public GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        jointDotClone = transform.gameObject;

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Vector2.Distance(player.transform.position, transform.position));
        if(distance<Vector2.Distance(player.transform.position, transform.position))
        {
            CreateJoint();
            distance +=2f;
        }
    }

    void CreateJoint()
    {
        Vector2 spawnJointPos;
        if (!jointDotClone)
        {
            spawnJointPos = spawnPoint.transform.position - jointDot.transform.position;
        }
        else
        {
            spawnJointPos = spawnPoint.transform.position - jointDotClone.transform.position;
        }

        GameObject newDot = Instantiate(jointDot, spawnJointPos, Quaternion.identity) as GameObject;
        newDot.transform.SetParent(transform);
        jointDotClone.GetComponent<HingeJoint2D>().connectedBody.GetComponent<Rigidbody2D>();
        jointDotClone = newDot;


    }

}
