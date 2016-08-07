using UnityEngine;
using System.Collections;

public class Despawner : MonoBehaviour {

    void OnTriggerEnter2D (Collider2D coll)
    {
        Debug.Log("Collision: " + coll.name);
        if (coll.tag == "Bitzen")
        {
            Destroy(coll.gameObject);
        }
    }

}
