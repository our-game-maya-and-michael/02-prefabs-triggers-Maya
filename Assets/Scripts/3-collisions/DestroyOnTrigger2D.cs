using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTagDestroy;

    [SerializeField] string triggeringTagLife=null;

    [Tooltip("Number of lives")]
    [SerializeField] int lives;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTagDestroy)
        {
            lives--;
            if (lives <= 0)
            {
                Destroy(this.gameObject);
            }
            Destroy(other.gameObject);
        }
        else if(other.tag == triggeringTagLife)
        {
            lives++;
            Destroy(other.gameObject);
        }
    }

    private void Update() {
        /* Just to show the enabled checkbox in Editor */
    }
}
