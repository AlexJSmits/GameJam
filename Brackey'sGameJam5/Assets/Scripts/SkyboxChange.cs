using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChange : MonoBehaviour
{
    public Material skybox1;
    public Material skybox2;


    private void Start()
    {
        RenderSettings.skybox = skybox1;
    }
    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
            RenderSettings.skybox = skybox2;
    }

    // Update is called once per frame
    private void OnTriggerExit(Collider target)
    {
        if (target.tag == "Player")
            RenderSettings.skybox = skybox1;
    }
}
