using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class DragDropScript : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public static GameObject draggedItem;
	public ItemType itemType;
	public string pathOfItemToEquip;
	public string pathOfItemToEquip2;

	Vector3 startPosition;
	Transform startParent; // this is the original slot the item was inside of

	public void OnBeginDrag(PointerEventData eventData){
		draggedItem = gameObject;
		startPosition = transform.position;
		startParent = transform.parent;
		GetComponent<CanvasGroup>().blocksRaycasts = false;
	}

	public void OnDrag (PointerEventData eventData){
		transform.position = eventData.position;
	}

	public void OnEndDrag(PointerEventData eventData){
		draggedItem = null;
		GetComponent<CanvasGroup>().blocksRaycasts = true;
		if (transform.parent == startParent) {
			transform.position = startPosition;
		}
	}
}












