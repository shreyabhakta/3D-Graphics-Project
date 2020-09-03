﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
	private void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Enemy")
		{
			Destroy(other.gameObject);
		}
	}
}
