using UnityEngine;
using System.Collections;

// basic script to have the camera follow the player while maintaining a constant rotation
// Has assumption of 50-degree X-axis rotation hard-coded
public class CamFollow : MonoBehaviour {
    public Transform follow;
    [SerializeField]
    private float camDistance;
    private Vector3 camVector;

    void Start() {
        camVector = new Vector3(0, camDistance / Mathf.Cos(Mathf.Deg2Rad * 50), camDistance / Mathf.Sin(Mathf.Deg2Rad * 50));
    }
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector3(follow.position.x, follow.position.y + camVector.y, follow.position.z - camVector.z);
	}
}
