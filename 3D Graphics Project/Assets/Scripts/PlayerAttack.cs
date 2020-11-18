using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttack : MonoBehaviour
{
	public int health = 3;
	public int numOfHearts = 3;
	public RawImage[] hearts;
	public RawImage fullHeart;
	public RawImage emptyHeart;
	public Transform spawnpoint;

	// Update is called once per frame
    void Update() 
	{
		if(health > numOfHearts) {
			health = numOfHearts;
		}
        for(int i = 0; i < hearts.Length; i++) {
        	if(i < health) {
        		hearts[i].texture = fullHeart.texture;
        	}
			else {
				hearts[i].texture = emptyHeart.texture;
			}
			
			if(i < numOfHearts) {
				hearts[i].enabled = true;
			}
			else {
				hearts[i].enabled = false;
			}
        }
    }

	void OnCollisionEnter(Collision other)
    {
		if (other.transform.tag == "Enemy") {
			if(other.contacts[0].normal.y >= 0.9f) {
				print("Points colliding: " + other.contacts.Length);
				print("First point that collided: " + other.contacts[0].normal);
				Destroy(other.gameObject);
			}
			else {
				--health;
				Respawn();
			}
		}
		if (other.transform.tag == "Water")
		{
			// --health;
			Respawn();
		}
    }
	
	void Respawn() {
		this.transform.position = spawnpoint.position;
	}
}
