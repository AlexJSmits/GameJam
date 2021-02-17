using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteOld : MonoBehaviour
{
    public GameObject Prefab;
    void OnTriggerEnter()
    {
        Destroy(Prefab);
    } 
}
