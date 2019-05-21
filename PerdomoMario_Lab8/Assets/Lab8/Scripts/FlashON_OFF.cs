using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashON_OFF : MonoBehaviour
{
    private Light light;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Just turns on/off via the enable component of light and plays a sound
        if (Input.GetKeyDown(KeyCode.Mouse0))
            if (light.enabled == false)
            {
                light.enabled = true;
                audio.Play();
            }
            else
            {
                light.enabled = false;
                audio.Play();
            }
    }   
}
