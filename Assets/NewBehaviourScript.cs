using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class NewBehaviourScript : MonoBehaviour {
	float speed = 10.0f;
	float rotationSpeed = 100.0f;
	void Update () {
		float translation = CrossPlatformInputManager.GetAxis ("Vertical") * speed;
        float translation1 = CrossPlatformInputManager.GetAxis("Horizontal") * speed;

		translation *= Time.deltaTime;
		translation1 *= Time.deltaTime;
		transform.Translate (0, 0, translation);
		transform.Translate (translation1,0, 0);
	}
}
