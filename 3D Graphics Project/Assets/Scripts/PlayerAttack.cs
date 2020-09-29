using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
	public Transform spawnpoint;

	void OnCollisionEnter(Collision other)
    {
		if (other.transform.tag == "Enemy") {
			if(other.contacts[0].normal.y >= 0.9f) {
				Destroy(other.gameObject);
			}
		}
    }

	void Respawn() {
		this.transform.position = spawnpoint.position;
	} 
 }
