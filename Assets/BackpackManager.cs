﻿using UnityEngine;
using System.Collections;

public class BackpackManager : MonoBehaviour {

	public GameObject itemSlot1;
	public GameObject itemSlot2;
	public GameObject itemSlot3;
	public GameObject itemSlot4;
	public GameObject itemSlot5;
	public GameObject itemSlot6;

	public bool AddItem(GameObject obj){
		// todo: we need to get the image to add to the backpack
		// todo: we need to figure out if there is an empty slot in the backpack
		// if there isn't any empty slot, we return false
		if (itemSlot1.transform.childCount == 0) {
			obj.transform.SetParent (itemSlot1.transform);
			return true;
		}
		if (itemSlot2.transform.childCount == 0) {
			obj.transform.SetParent (itemSlot2.transform);
			return true;
		}

		if (itemSlot3.transform.childCount == 0) {
			obj.transform.SetParent (itemSlot3.transform);
			return true;
		}

		if (itemSlot4.transform.childCount == 0) {
			obj.transform.SetParent (itemSlot4.transform);
			return true;
		}

		if (itemSlot5.transform.childCount == 0) {
			obj.transform.SetParent (itemSlot5.transform);
			return true;
		}

		if (itemSlot6.transform.childCount == 0) {
			obj.transform.SetParent (itemSlot6.transform);
			return true;
		}

		// todo: we may want a message to say the backpacs is FULL
		return false;
	}


}
