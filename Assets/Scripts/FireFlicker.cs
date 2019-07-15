using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireFlicker : MonoBehaviour
{
    Light pointLight;
    float lightInterval;
    public float minInterval, maxInterval;
    public float firstTime, time;
    // Start is called before the first frame update
    void Start()
    {
        pointLight = GetComponent<Light>();
        time = firstTime;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        time -= Time.deltaTime;

        if (time <= 0)
        {
            lightInterval = Random.Range(minInterval, maxInterval);
            pointLight.intensity = lightInterval;
            time = firstTime;
        }
        
    }
}
