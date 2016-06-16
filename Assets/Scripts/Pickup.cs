using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {
    private static int totalCollected = 0;

    // When this pickup is touched by another collider, destroy this pickup and increase the count
    void OnTriggerEnter(Collider other) {
        ++totalCollected;
        Destroy(gameObject);
    }
}
