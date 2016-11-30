using UnityEngine;
using System.Collections;

public class DestroyerOnHit : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }
}
