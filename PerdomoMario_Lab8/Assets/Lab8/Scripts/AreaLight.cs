using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaLight : MonoBehaviour
{
    private Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        light.enabled = true;
        
    }
    private void OnTriggerStay(Collider other)
    {
        light.enabled = true;
        //It oscillates
        light.intensity = light.intensity + (2 * Mathf.Cos(5 * Time.time));
    }
    private void OnTriggerExit(Collider other)
    {
        light.enabled = false;
    }
    
}
