using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class FullTimeCharacter : MonoBehaviour {

	public int characterId = 0;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnMouseDown(){
		StartCoroutine(startBattleScene());
	}
	
	IEnumerator startBattleScene(){
		AsyncOperation AO = SceneManager.LoadSceneAsync("BattleScene",LoadSceneMode.Additive); 
		AO.allowSceneActivation = false;
		while(AO.progress < 0.9f)
		{
			yield return null;
		}

		//Fade the loading screen out here

		AO.allowSceneActivation = true;
	}
}
