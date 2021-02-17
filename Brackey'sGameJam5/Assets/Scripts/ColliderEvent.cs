using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColliderEvent : MonoBehaviour
{
    public UnityEvent EnterEvent;
    public UnityEvent ExitEvent;

    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Player")
            EnterEvent.Invoke();
    }

    void OnTriggerExit(Collider target)
    {
        if (target.tag == "Player")
        {
            ExitEvent.Invoke();
        }
    }
}
