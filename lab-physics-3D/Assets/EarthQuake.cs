using UnityEngine;

public class EarthQuake : MonoBehaviour {
    Rigidbody[] rigidbodies;
	
	void Start () {
	    rigidbodies = GameObject.FindObjectsOfType<Rigidbody>();
	}
	
	void Update () {
	    foreach (var rb in rigidbodies) {
	        rb.AddForce(Random.insideUnitSphere*Time.deltaTime*5000);

        }
	}
}
