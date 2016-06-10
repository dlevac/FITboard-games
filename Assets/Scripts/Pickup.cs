using UnityEngine;
using System.Collections;

public class Pickup : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // When this pickup is touched by another collider, destroy this pickup.
    void OnTriggerEnter(Collider other) {
        Destroy(gameObject);
    }
}
