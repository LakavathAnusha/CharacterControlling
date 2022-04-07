using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    float minPerSec = 60f;
    //public Light light;
    // Start is called before the first frame update
    void Start()
    {

       // light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        float angleTheFrame = Time.deltaTime / 2 *minPerSec;
        transform.RotateAround(transform.position, Vector3.forward, angleTheFrame);
    }

}
