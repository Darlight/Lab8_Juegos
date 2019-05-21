using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FPS : MonoBehaviour
{
    public Camera fpsCam;
    private RaycastHit hit;
    private string esfera = "This is a sphere";
    public Text description;
    private float fadeTime;
    private bool displayInfo;

    // Start is called before the first frame update
    void Start()
    {
        //The UI will be hiding
        description.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, 2f))
        {
            //If it hits with a sphere, the text appears
            if (hit.collider.gameObject.CompareTag("Sphere"))
            {
                description.enabled = true;
                description.text = esfera;
            }
            else
                // UI hides 
                description.enabled = false;
        }

    }
}
