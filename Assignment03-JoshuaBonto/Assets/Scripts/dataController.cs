using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dataController : MonoBehaviour {
	public float varA=0f, varB=0f, varC=0f;
	public Text vtA, vtB, vtC;
	// Use this for initialization
	void Start () {
		//loads the data and updates the UI
		varA = PlayerPrefs.GetFloat ("sVarA");
		varB = PlayerPrefs.GetFloat ("sVarB");
		varC = PlayerPrefs.GetFloat ("sVarC");


		vtA.text = "Variable A: " + varA.ToString ();
		vtB.text = "Variable B: " + varB.ToString ();
		vtC.text = "Variable C: " + varC.ToString ();
	}

	public void modifyData(char c){
		//based on the char passed the script increases a variable, and updates the UI
		if (c == 'a') {
			varA++;
			vtA.text = "Variable A: " + varA.ToString ();
		} else if (c == 'b') {
			varB++;
			vtB.text = "Variable B: " + varB.ToString ();
		} else if (c == 'c') {
			varC++;
			vtC.text = "Variable C: " + varC.ToString ();
		} else {
			Debug.Log ("Error");
		}
	}
	public void resetData(){
		varA = 0f;//set the data to 0 in scene
		varB = 0f;
		varC = 0f;


		vtA.text = "Variable A: " + varA.ToString ();//adjust the UI accordingly
		vtB.text = "Variable B: " + varB.ToString ();
		vtC.text = "Variable C: " + varC.ToString ();


		PlayerPrefs.SetFloat ("sVarA", 0f);//set the player prefs accordingly
		PlayerPrefs.SetFloat ("sVarB", 0f);
		PlayerPrefs.SetFloat ("sVarC", 0f);
		Debug.Log ("Data has been reset");
	}
	void OnApplicationQuit(){
		//saves all data when you quit
		PlayerPrefs.SetFloat ("sVarA", varA);
		PlayerPrefs.SetFloat ("sVarB", varB);
		PlayerPrefs.SetFloat ("sVarC", varC);
		Debug.Log ("Application terminated, data has been saved");
	}
}
