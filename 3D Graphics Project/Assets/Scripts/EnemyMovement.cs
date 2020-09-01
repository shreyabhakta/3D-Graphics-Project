using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
	public float speed = 2f;
	public bool movingRight = true;

	// Update is called once per frame
	void Update()
	{
		if (movingRight)
		{
			transform.Translate(0, 0, 2 * Time.deltaTime * speed);
		}
		else
		{
			transform.Translate(0, 0, -2 * Time.deltaTime * speed);
		}
	}

	void OnTriggerEnter(Collider other)
	{
		Debug.Log(other.transform.tag);
		if (other.transform.tag == "turn")
		{
			if (movingRight == true)
			{
				movingRight = false;
				Debug.Log("TURN!");
			}
			else
			{
				movingRight = true;
				Debug.Log("TURN AGAIN!");
			}
		}
	}
}
