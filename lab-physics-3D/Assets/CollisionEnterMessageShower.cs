using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEnterMessageShower : MonoBehaviour {

    void OnCollisionEnter(Collision collision) {
        Debug.Log(gameObject.name + " has just collided!\n", this);
    }
}
