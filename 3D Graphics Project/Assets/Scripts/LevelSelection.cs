using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour {
	public int sceneLoadIndex;

	public Button[] levelButtons;
    // Start is called before the first frame update
    void Start() {
		int levelAt = PlayerPrefs.GetInt("levelAt", 1);
        
		for(int i = 0; i < levelButtons.Length; i++) {
			if( i + 1 > levelAt) {
				levelButtons[i].interactable = false;
			}
		}
    }

	public void LoadScene() {
		SceneManager.LoadScene(sceneLoadIndex);
	}
}
