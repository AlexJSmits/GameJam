using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOld : MonoBehaviour
{
    public GameObject Prefab;
    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
            Destroy(Prefab);
    } 
}
