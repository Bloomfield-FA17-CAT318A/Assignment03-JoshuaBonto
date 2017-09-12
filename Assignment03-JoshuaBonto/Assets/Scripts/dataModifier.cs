using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class dataModifier : MonoBehaviour {
	public enum dataList{varA, varB, varC}
	public dataList whichData;
	public dataController thisData;
	// The finite state machine

	public void buttonPunch(){
		if (whichData == dataList.varA) {
			thisData.modifyData ('a');
		} else if (whichData == dataList.varB) {
			thisData.modifyData ('b');
		} else {
			thisData.modifyData ('c');
		}
	}
}
