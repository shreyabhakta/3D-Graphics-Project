using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
	void OnCollisionEnter(Collision other)
    {
		if (other.transform.tag == "Enemy") {
			if(other.contacts[0].normal.y >= 0.9f) {
				print("Points colliding: " + other.contacts.Length);
				print("First point that collided: " + other.contacts[0].normal);
				Destroy(other.gameObject);
			}
		}
    }
}
