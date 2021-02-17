using UnityEngine;
using UnityEngine.Events;

public class LevelLoop : MonoBehaviour
{
    private bool isLooking;
    public GameObject Prefab;
    public Transform spawnLocation;
    public UnityEvent onInteract;

    void OnMouseEnter()
    {
        isLooking = true;
        Debug.Log("Is looking");
    }

    void OnMouseExit()
    {
        isLooking = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (isLooking == true)
        {
            Instantiate(Prefab, spawnLocation.position, spawnLocation.rotation);
            onInteract.Invoke();
            Destroy(GetComponent<BoxCollider>());
        }
    }

}

