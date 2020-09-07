using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisons : MonoBehaviour
{
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
}
