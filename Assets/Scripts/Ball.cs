using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
    // Stores/caches rigidbody for ease of access.
    private new Rigidbody rigidbody;

    // Force applied to ball on push, set in Unity editor.
    [SerializeField]
    private float pushForce;

    // First-thing initialization
    void Awake() {
        rigidbody = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void Update () {
        Push();
	}

    // called when this object enters a Trigger collider
    void OnTriggerEnter(Collider other) {
        //TODO score counter?
        // temporary console logging just to show it works
        Debug.Log("Ball logs collision");
    }

    /// <summary>
    /// Detect input to push the ball.
    /// Handles orthogonal inputs but not opposite ones.
    /// In case of opposite inputs, prioritizes right over left and up over down.
    /// </summary>
    private void Push() {
        if (Input.GetButtonDown("Horizontal"))
        {
            if (Input.GetAxis("Horizontal") > 0)
                rigidbody.AddForce(pushForce, 0, 0, ForceMode.Impulse);
            else
                rigidbody.AddForce(-pushForce, 0, 0, ForceMode.Impulse);
        }
        if (Input.GetButtonDown("Vertical"))
        {
            if (Input.GetAxis("Vertical") > 0)
                rigidbody.AddForce(0, 0, pushForce, ForceMode.Impulse);
            else
                rigidbody.AddForce(0, 0, -pushForce, ForceMode.Impulse);
        }
    }
}
