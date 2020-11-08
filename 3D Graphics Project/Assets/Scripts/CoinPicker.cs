using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPicker : MonoBehaviour
{
	public TextMeshProUGUI coinText;
	public float coins = 0;

	private void OnTriggerEnter(Collider other)
	{
		if (other.transform.tag == "Coin")
		{
			coins++;
			coinText.text = coins.ToString();
			Destroy(other.gameObject);
		}
	}
}
