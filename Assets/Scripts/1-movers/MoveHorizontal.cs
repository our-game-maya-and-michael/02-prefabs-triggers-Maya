using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveHorizon : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will trigger the movement of the object to the right")]
    [SerializeField] string triggeringTagRight;
    [Tooltip("Every object tagged with this tag will trigger the movement of the object to the left")]
    [SerializeField] string triggeringTagLeft;
    private float screenSize = 10f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == triggeringTagRight && enabled)
        {
            // If hitting the left wall, move to the right side
            transform.position = new Vector3(screenSize, transform.position.y, transform.position.z);
        }
        else if (other.tag == triggeringTagLeft && enabled)
        {
            // If hitting the right wall, move to the left side
            transform.position = new Vector3(-screenSize, transform.position.y, transform.position.z);
        }
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}
