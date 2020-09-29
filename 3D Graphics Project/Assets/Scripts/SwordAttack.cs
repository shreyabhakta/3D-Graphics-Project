using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{
	void OnCollisionEnter(Collision other)
    {
		if (other.transform.tag == "Sword") {
			print(other.gameObject);
			Destroy(other.gameObject);
		}
    }
}