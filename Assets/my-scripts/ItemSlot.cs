﻿using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler {

	public ItemType allowedItemType;
	public bool isEquippable = false;
	SlotEquipItem script;

	public GameObject item {
		// the first child of the item slot is the image being dragged
		get {
			if (transform.childCount != 0) {
				return transform.GetChild (0).gameObject;
			}
			return null;
		}
	}
	public void OnDrop(PointerEventData eventData){
		if (item == null) {
			// this slot is empty, we can drop an item inside of item
			GameObject itemBeingDragged = DragDropScript.draggedItem;

			script = itemBeingDragged.GetComponentInParent<SlotEquipItem> ();
			if(script != null){
				switch (itemBeingDragged.GetComponentInParent<ItemSlot>().allowedItemType) {
				case ItemType.Helmet:
					script.UnequipHelmet ();
					break;

				case ItemType.Shoulders:
					script.UnequipShoulders ();
					break;

				case ItemType.Weapon:
					script.UnequipWeapon ();
					break;

				case ItemType.Shield:
					script.UnequipShield ();
					break;

				case ItemType.Buckle:
					script.UnequipBuckle();
					break;

				default:
					break;

				}
			}

			// we need the item type of the item being dragged
			ItemType draggedItemType = itemBeingDragged.GetComponent<DragDropScript>().itemType;
			if( isItemTypeCorrect(draggedItemType)  ){
					itemBeingDragged.transform.SetParent (transform);
				if (isEquippable) {
					script = GetComponent<SlotEquipItem> ();
					if(script != null){
						switch (allowedItemType) {
						case ItemType.Helmet:
							script.EquipItemOnHead ();
							break;

						case ItemType.Shoulders:
							script.EquipItemOnShoulders ();
							break;

						case ItemType.Weapon:
							script.EquipWeapon ();
							break;

						case ItemType.Shield:
							script.EquipShield ();
							break;

						case ItemType.Buckle:
							script.EquipBuckle();
							break;

						case ItemType.Trash:
							UnequipItemBeingDragged ();
							Destroy (itemBeingDragged);
							return;
							break;

						default:
							break;
							
						}
					}
				}
			}
		} else {

			// THIS IS THE CASE THERE IS ALREADY AN ITEM IN THE SLOT
			GameObject itemBeingDragged = DragDropScript.draggedItem;
			ItemType draggedItemType = itemBeingDragged.GetComponent<DragDropScript>().itemType;
			if (isItemTypeCorrect (draggedItemType)) {
				script = itemBeingDragged.GetComponentInParent<SlotEquipItem> ();
				if(script != null){
					switch (allowedItemType) {
					case ItemType.Helmet:
						script.UnequipHelmet ();
						break;

					case ItemType.Shoulders:
						script.UnequipShoulders ();
						break;

					case ItemType.Weapon:
						script.UnequipWeapon ();
						break;

					case ItemType.Shield:
						script.UnequipShield ();
						break;

					case ItemType.Buckle:
						script.UnequipBuckle();
						break;

					default:
						break;

					}
				}

				if (isItemTypeCorrect (draggedItemType)) {
					if (isEquippable) {
						script = GetComponent<SlotEquipItem> ();
						if (script != null) {
							switch (allowedItemType) {
							case ItemType.Helmet:
								script.EquipItemOnHead ();
								break;

							case ItemType.Shoulders:
								script.EquipItemOnShoulders ();
								break;

							case ItemType.Weapon:
								script.EquipWeapon ();
								break;

							case ItemType.Shield:
								script.EquipShield ();
								break;

							case ItemType.Buckle:
								script.EquipBuckle ();
								break;

							case ItemType.Trash:
								UnequipItemBeingDragged ();
								Destroy (itemBeingDragged);
								return;
								break;

							default:
								break;

							}
						}
					}
					item.transform.SetParent (itemBeingDragged.transform.parent);
					itemBeingDragged.transform.SetParent (transform);
				}
			}

		}
	}

	bool isItemTypeCorrect(ItemType type){
		if (allowedItemType == ItemType.Any || allowedItemType == ItemType.Trash) {
			return true;
		}
		return allowedItemType == type;
	}


	void UnequipItemBeingDragged(){
		GameObject itemBeingDragged = DragDropScript.draggedItem;
		ItemType draggedItemType = itemBeingDragged.GetComponent<DragDropScript>().itemType;
		script = itemBeingDragged.GetComponentInParent<SlotEquipItem> ();
		if (script != null) {
			switch (draggedItemType) {
			case ItemType.Helmet:
				script.UnequipHelmet ();
				break;

			case ItemType.Shoulders:
				script.UnequipShoulders ();
				break;

			case ItemType.Weapon:
				script.UnequipWeapon ();
				break;

			case ItemType.Shield:
				script.UnequipShield ();
				break;

			case ItemType.Buckle:
				script.UnequipBuckle ();
				break;

			default:
				break;

			}
		}
	}

}












