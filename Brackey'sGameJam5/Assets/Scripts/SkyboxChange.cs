using UnityEngine;

public class SkyboxChange : MonoBehaviour
{
    public Material skybox1;
    public Material skybox2;
 
    private void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
            RenderSettings.skybox = skybox2;
    }

    private void OnTriggerExit(Collider target)
    {
        if (target.tag == "Player")
            RenderSettings.skybox = skybox1;
    }
}
