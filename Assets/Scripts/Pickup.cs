using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {
    private static int _score = 0;
    public static int totalCollected { get { return _score;} }



    // When this pickup is touched by another collider, destroy this pickup and increase the count
    void OnTriggerEnter(Collider other) {
        ++_score;
        Destroy(gameObject);
    }
}
