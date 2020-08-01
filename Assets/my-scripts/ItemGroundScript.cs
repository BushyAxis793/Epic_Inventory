using UnityEngine;
using System.Collections;

public class ItemGroundScript : MonoBehaviour {

	public string NameOfItemToEquip;
	public string whereToEquipItem;
	public int quality = 0;
	public string NameOfSlotImage;
	// Use this for initialization
	void Start () {

		SetNameColor (quality);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other){
		if (other.gameObject.tag == "Player") {
			/*if (whereToEquipItem == "rightHand") {
				GameObject item = Instantiate (Resources.Load (NameOfItemToEquip, typeof(GameObject))) as GameObject;
				other.gameObject.GetComponent<EquipItemScript> ().EquipRightHandWith (item);
			} else if (whereToEquipItem == "leftHand") {
				GameObject item = Instantiate (Resources.Load (NameOfItemToEquip, typeof(GameObject))) as GameObject;
				other.gameObject.GetComponent<EquipItemScript> ().EquipShield (item);
			} else if (whereToEquipItem == "head") {
				GameObject item = Instantiate (Resources.Load (NameOfItemToEquip, typeof(GameObject))) as GameObject;
				other.gameObject.GetComponent<EquipItemScript> ().EquipHeadWith (item);
			} else if (whereToEquipItem == "buckle") {
				GameObject item = Instantiate (Resources.Load (NameOfItemToEquip, typeof(GameObject))) as GameObject;
				other.gameObject.GetComponent<EquipItemScript> ().EquipBuckleWith (item);
			} else if (whereToEquipItem == "shoulders") {
				string leftShoulderName = NameOfItemToEquip + "-left";
				string rightShoulderName = NameOfItemToEquip + "-right";
				GameObject itemLeft = Instantiate (Resources.Load (leftShoulderName, typeof(GameObject))) as GameObject;
				GameObject itemRight = Instantiate (Resources.Load (rightShoulderName, typeof(GameObject))) as GameObject;
				other.gameObject.GetComponent<EquipItemScript> ().EquipLeftShoulderWith (itemLeft);
				other.gameObject.GetComponent<EquipItemScript> ().EquipRightShoulderWith (itemRight);
			}*/
			// todo: add item to inventory (backpack)
			GameObject imageObject = Instantiate(Resources.Load(NameOfSlotImage)) as GameObject;

			//GameObject backpack = GameObject.FindGameObjectWithTag("Backpack");
			GameObject player = GameObject.FindGameObjectWithTag("Player");
			GameObject backpack = player.GetComponent<EquipItemScript> ().backpack;
			backpack.GetComponent<BackpackManager> ().AddItem (imageObject);
			Destroy (this.gameObject);

		}
	}

	public void SetNameColor(int value){
		Color color = Color.gray;
		switch (value) {
		case 1:
			color = Color.white;
			break;
		case 2:
			color = Color.blue;
			break;
		case 3:
			color = Color.yellow;
			break;
		case 4:
			color = new Color (r: 1.0f, g: 155/255, b: 51/255, a: 1.0f); // Orange color
			break;
		default:
			color = Color.gray;
			break;
		}
		transform.FindChild("Name").gameObject.GetComponent<TextMesh>().color = color;
	}

}














