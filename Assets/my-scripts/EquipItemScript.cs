using UnityEngine;
using System.Collections;

public class EquipItemScript : MonoBehaviour {

	public GameObject HookRightHand;
	public GameObject HookLeftForeArm;
	public GameObject HookHead;
	public GameObject HookLeftShoulder;
	public GameObject HookRightShoulder;
	public GameObject HookBuckle;

	public GameObject backpack;

	public int useEquipmentSet = 0;

	void Start(){
		/*if (useEquipmentSet == 0) {
			EquipTestItems1 ();
		} else {
			EquipTestItems2 ();
		}*/
	}

	public void EquipRightHandWith(GameObject weapon){


		int i = 0;
		for (i = 0; i < HookRightHand.transform.childCount; i++) {
			Destroy (HookRightHand.transform.GetChild (i).gameObject);
		}
		weapon.transform.parent = HookRightHand.transform;
		Vector3 offset = weapon.GetComponent<HookScript> ().positionOffset;

		weapon.transform.position = HookRightHand.transform.position;
		weapon.transform.rotation = HookRightHand.transform.rotation;
		weapon.transform.localPosition = Vector3.zero + offset;
	}

	public void EquipShield(GameObject shield){
		int i = 0;
		for (i = 0; i < HookLeftForeArm.transform.childCount; i++) {
			Destroy (HookLeftForeArm.transform.GetChild (i).gameObject);
		}
		shield.transform.parent = HookLeftForeArm.transform;
		Vector3 offset = shield.GetComponent<HookScript> ().positionOffset;

		shield.transform.position = HookLeftForeArm.transform.position;
		shield.transform.rotation = HookLeftForeArm.transform.rotation;

		shield.transform.localPosition = Vector3.zero + offset;


		Vector3 rotOffset = shield.GetComponent<HookScript> ().rotationOffset;
		shield.transform.Rotate (rotOffset);
	}


	public void EquipHeadWith(GameObject helmet){
		int i = 0;
		for (i = 0; i < HookHead.transform.childCount; i++) {
			Destroy (HookHead.transform.GetChild (i).gameObject);
		}

		helmet.transform.parent = HookHead.transform;
		Vector3 offset = helmet.GetComponent<HookScript> ().positionOffset;


		helmet.transform.position = HookHead.transform.position;
		helmet.transform.rotation = HookHead.transform.rotation;

		helmet.transform.localPosition = Vector3.zero + offset;


		Vector3 rotOffset = helmet.GetComponent<HookScript> ().rotationOffset;
		helmet.transform.Rotate (rotOffset);
	}

	public void EquipLeftShoulderWith(GameObject shoulder){
		int i = 0;
		for (i = 0; i < HookLeftShoulder.transform.childCount; i++) {
			Destroy (HookLeftShoulder.transform.GetChild (i).gameObject);
		}
		shoulder.transform.parent = HookLeftShoulder.transform;
		Vector3 offset = shoulder.GetComponent<HookScript> ().positionOffset;

		shoulder.transform.position = HookLeftShoulder.transform.position;
		shoulder.transform.rotation = HookLeftShoulder.transform.rotation;

		shoulder.transform.localPosition = Vector3.zero + offset;

		Vector3 rotOffset = shoulder.GetComponent<HookScript> ().rotationOffset;
		shoulder.transform.Rotate (rotOffset);
	}

	public void EquipRightShoulderWith(GameObject shoulder){
		int i = 0;
		for (i = 0; i < HookRightShoulder.transform.childCount; i++) {
			Destroy (HookRightShoulder.transform.GetChild (i).gameObject);
		}
		shoulder.transform.parent = HookRightShoulder.transform;
		Vector3 offset = shoulder.GetComponent<HookScript> ().positionOffset;

		shoulder.transform.position = HookRightShoulder.transform.position;
		shoulder.transform.rotation = HookRightShoulder.transform.rotation;

		shoulder.transform.localPosition = Vector3.zero + offset;

		Vector3 rotOffset = shoulder.GetComponent<HookScript> ().rotationOffset;
		shoulder.transform.Rotate (rotOffset);
	}


	public void EquipBuckleWith(GameObject buckle){
		int i = 0;
		for (i = 0; i < HookBuckle.transform.childCount; i++) {
			Destroy (HookBuckle.transform.GetChild (i).gameObject);
		}
		buckle.transform.parent = HookBuckle.transform;
		Vector3 offset = buckle.GetComponent<HookScript> ().positionOffset;

		buckle.transform.position = HookBuckle.transform.position;
		buckle.transform.rotation = HookBuckle.transform.rotation;

		buckle.transform.localPosition = Vector3.zero + offset;

		Vector3 rotOffset = buckle.GetComponent<HookScript> ().rotationOffset;
		buckle.transform.Rotate (rotOffset);
	}

	void EquipTestItems1(){
		GameObject sword = Instantiate (Resources.Load ("MyPrefabs/gear/sword-simple-1", typeof(GameObject))) as GameObject;
		EquipRightHandWith (sword);

		GameObject shield = Instantiate (Resources.Load ("MyPrefabs/gear/shield-3", typeof(GameObject))) as GameObject;
		EquipShield (shield);

		GameObject helmet = Instantiate (Resources.Load ("MyPrefabs/gear/helmet-3", typeof(GameObject))) as GameObject;
		EquipHeadWith (helmet);

		GameObject leftShoulder = Instantiate (Resources.Load ("MyPrefabs/gear/shoulder-1-left", typeof(GameObject))) as GameObject;
		EquipLeftShoulderWith (leftShoulder);

		GameObject rightShoulder = Instantiate (Resources.Load ("MyPrefabs/gear/shoulder-1-right", typeof(GameObject))) as GameObject;
		EquipRightShoulderWith (rightShoulder);

		GameObject buckle = Instantiate (Resources.Load ("MyPrefabs/gear/buckle-1", typeof(GameObject))) as GameObject;
		EquipBuckleWith (buckle);
	}

	void EquipTestItems2(){
		GameObject sword = Instantiate (Resources.Load ("MyPrefabs/gear/sword-simple-2", typeof(GameObject))) as GameObject;
		EquipRightHandWith (sword);

		GameObject shield = Instantiate (Resources.Load ("MyPrefabs/gear/shield-round-wood", typeof(GameObject))) as GameObject;
		EquipShield (shield);

		GameObject helmet = Instantiate (Resources.Load ("MyPrefabs/gear/helmet-2", typeof(GameObject))) as GameObject;
		EquipHeadWith (helmet);

		GameObject leftShoulder = Instantiate (Resources.Load ("MyPrefabs/gear/shoulder-2-left", typeof(GameObject))) as GameObject;
		EquipLeftShoulderWith (leftShoulder);

		GameObject rightShoulder = Instantiate (Resources.Load ("MyPrefabs/gear/shoulder-2-right", typeof(GameObject))) as GameObject;
		EquipRightShoulderWith (rightShoulder);

		GameObject buckle = Instantiate (Resources.Load ("MyPrefabs/gear/buckle-2", typeof(GameObject))) as GameObject;
		EquipBuckleWith (buckle);
	}

	public void UnequipHead(){
		int i = 0;
		for (i = 0; i < HookHead.transform.childCount; i++) {
			Destroy (HookHead.transform.GetChild (i).gameObject);
		}
	}

	public void UnequipShoulders(){
		int i = 0;
		for (i = 0; i < HookLeftShoulder.transform.childCount; i++) {
			Destroy (HookLeftShoulder.transform.GetChild (i).gameObject);
			Destroy (HookRightShoulder.transform.GetChild (i).gameObject);
		}
	}

	public void UnequipRightHand(){
		int i = 0;
		for (i = 0; i < HookRightHand.transform.childCount; i++) {
			Destroy (HookRightHand.transform.GetChild (i).gameObject);
		}
	}

	public void UnequipShield(){
		int i = 0;
		for (i = 0; i < HookLeftForeArm.transform.childCount; i++) {
			Destroy (HookLeftForeArm.transform.GetChild (i).gameObject);
		}
	}

	public void UnequipBuckle(){
		int i = 0;
		for (i = 0; i < HookBuckle.transform.childCount; i++) {
			Destroy (HookBuckle.transform.GetChild (i).gameObject);
		}
	}

}
















