using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ColliderEvent : MonoBehaviour
{
    public UnityEvent EnterEvent;
    public UnityEvent ExitEvent;
    // Start is called before the first frame update
    void OnTriggerEnter()
    {
        EnterEvent.Invoke();
    }

    void OnTriggerExit()
    {
        ExitEvent.Invoke();
    }
}
