using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine;

public class AnswerPhone : MonoBehaviour
{
    private bool isLooking;
    public UnityEvent onTrigger;
    void OnMouseEnter()
    {
        isLooking = true;
    }

    void OnMouseExit()
    {
        isLooking = false;
    }

    void OnTriggerStay(Collider target)
    {
        if (target.tag == "Player" && (isLooking == true))
        {
            onTrigger.Invoke();
        }
    }
}
