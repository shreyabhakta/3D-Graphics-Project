using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPicker : MonoBehaviour
{
	public float coins = 0;
	//public TextMeshProUGUI coinText;
	private void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Coin")
		{
			coins++;
			//coinText.text = coins.ToString();
			Destroy(other.gameObject);
		}
	}
}
