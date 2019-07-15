using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TorchSpawn : MonoBehaviour
{
    public Transform spawnLocation;
    public GameObject torch;
    public GameObject torchClone;

    // Start is called before the first frame update
    void Start()
    {
        spawnTorch();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnTorch()
    {
        torchClone = Instantiate(torch, spawnLocation);
    }
}
