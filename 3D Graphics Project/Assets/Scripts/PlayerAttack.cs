using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerAttack : MonoBehaviour
{
	public int health = 3;
	public int numOfHearts = 3;
	public RawImage[] hearts;
	public RawImage fullHeart;
	public RawImage emptyHeart;
	public Transform spawnpoint;
	public int nextSceneLoad;

	// Update is called once per frame
    void Update() 
	{
		if(health > numOfHearts) {
			health = numOfHearts;
		}
        for(int i = 0; i < hearts.Length; i++) {
        	if(health == 0) {
				SceneManager.LoadScene(21);
			}
			else if(i < health) {
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
		Debug.Log(other.transform.tag);
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
			//--health;
			Respawn();
		}
		if(other.transform.tag == "Finish") {
			if(SceneManager.GetActiveScene().buildIndex == 20) {
				Debug.Log("YOU HAVE COMPLETED THE GAME");
				//back to main menu

				PlayerPrefs.SetInt("levelAt", nextSceneLoad);
			}
			else {
				//Move to the next level
				SceneManager.LoadScene(nextSceneLoad);
				//Set int for Index
				if(nextSceneLoad > PlayerPrefs.GetInt("levelAt")) {
					PlayerPrefs.SetInt("levelAt", nextSceneLoad);
				}
			}
		}
    }
	
	void Respawn() {
		this.transform.position = spawnpoint.position;
	}
}
