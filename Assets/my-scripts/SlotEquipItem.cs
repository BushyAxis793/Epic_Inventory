using UnityEngine;
using System.Collections;

public class SlotEquipItem : MonoBehaviour {

	public GameObject player;
	public string pathOfItemToEquip;
	public string pathOfItemToEquip2;

	void Start(){
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	public void EquipItemOnHead(){
		// todo:
		// we want to remove any item on that slot and on the character (if any)
		// add the item to the player character
		string itemPath = DragDropScript.draggedItem.GetComponent<DragDropScript>().pathOfItemToEquip;
		GameObject item = Instantiate( Resources.Load(itemPath)) as GameObject;
		player.GetComponent<EquipItemScript> ().EquipHeadWith (item);

	}

	public void EquipItemOnShoulders(){
		string itemPath = DragDropScript.draggedItem.GetComponent<DragDropScript>().pathOfItemToEquip;
		GameObject item = Instantiate( Resources.Load(itemPath)) as GameObject;
		player.GetComponent<EquipItemScript> ().EquipLeftShoulderWith(item);

		string itemPath2 = DragDropScript.draggedItem.GetComponent<DragDropScript>().pathOfItemToEquip2;
		GameObject item2 = Instantiate( Resources.Load(itemPath2)) as GameObject;
		player.GetComponent<EquipItemScript> ().EquipRightShoulderWith(item2);
	}

	public void EquipWeapon(){
		string itemPath = DragDropScript.draggedItem.GetComponent<DragDropScript>().pathOfItemToEquip;
		GameObject item = Instantiate( Resources.Load(itemPath)) as GameObject;
		player.GetComponent<EquipItemScript> ().EquipRightHandWith(item);
	}

	public void EquipShield(){
		string itemPath = DragDropScript.draggedItem.GetComponent<DragDropScript>().pathOfItemToEquip;
		GameObject item = Instantiate( Resources.Load(itemPath)) as GameObject;
		player.GetComponent<EquipItemScript> ().EquipShield(item);
	}

	public void EquipBuckle(){
		string itemPath = DragDropScript.draggedItem.GetComponent<DragDropScript>().pathOfItemToEquip;
		GameObject item = Instantiate( Resources.Load(itemPath)) as GameObject;
		player.GetComponent<EquipItemScript> ().EquipBuckleWith(item);
	}

	public void UnequipHelmet(){
		player.GetComponent<EquipItemScript> ().UnequipHead ();
	}

	public void UnequipShoulders(){
		player.GetComponent<EquipItemScript> ().UnequipShoulders ();
	}

	public void UnequipWeapon(){
		player.GetComponent<EquipItemScript> ().UnequipRightHand ();
	}

	public void UnequipShield(){
		player.GetComponent<EquipItemScript> ().UnequipShield ();
	}

	public void UnequipBuckle(){
		player.GetComponent<EquipItemScript> ().UnequipBuckle ();
	}
}
