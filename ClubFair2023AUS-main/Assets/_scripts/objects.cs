using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objects : MonoBehaviour
{
    public int sortingOrder = 0; // Set the initial sorting order here
    public GameObject player;
    private float timer = 0f;
    public float DeleteAfter = 8f;

    // Update is called once per frame
    void Start() // It should be "Start" instead of "start" for proper Unity method execution.
    {
        timer = Time.time;
        // Set the initial sorting order when the object is created.
        SetSortingOrder(4);
    }

    void Update()
    {
        if ((Time.time - timer) > DeleteAfter)
        {
            // Destroy the GameObject when the timer expires.
            Destroy(gameObject);
        }
    }

    // Function to set the sorting order of the GameObject
    void SetSortingOrder(int order)
    {
        Renderer renderer = GetComponent<Renderer>();

        if (renderer != null)
        {
            renderer.sortingOrder = order;
        }
        else
        {
            Debug.LogWarning("No Renderer component found on this GameObject.");
        }
    }
}
