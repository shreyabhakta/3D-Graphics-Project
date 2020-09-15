using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisons : MonoBehaviour
{
<<<<<<< HEAD
	public Transform spawnpoint;

	private void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Water")
		{
			Respawn();
		}
	}
	
	void Respawn() {
		this.transform.position = spawnpoint.position;
	}
=======
	public class PlayerAttack : MonoBehaviour
	{
		private void OnTriggerEnter(Collider other)
		{
			if (other.transform.tag == "Player")
			{
				Destroy(other.gameObject);
			}
		}
	}
>>>>>>> anh_main
}
