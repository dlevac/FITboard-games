using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreUpdate : MonoBehaviour {
    Text displayText;

    void Start() {
        displayText = GetComponent<Text>();
    }

	// Update is called once per frame
	void Update () {
        displayText.text = Pickup.totalCollected.ToString();
	}
}
