using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;


public class PlayerBehaviorScript : MonoBehaviour {

	public float speed = 2.0f;
	Vector3 movement;
	Animator animator;
	bool isAttacking = false;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator> ();	
	}
	
	void FixedUpdate(){
		float h = CrossPlatformInputManager.GetAxisRaw ("Horizontal");
		float v = CrossPlatformInputManager.GetAxisRaw ("Vertical");

		movement.Set (h, 0f, v);
		movement = movement.normalized * Time.fixedDeltaTime * speed;

		animator.SetFloat ("speed", v);
		animator.SetFloat("strafe", -h);


		if (Input.GetButtonDown ("Jump")) {
			if (isAttacking == false) {
				animator.SetTrigger ("attack");
				Invoke ("AttackAnimationOver", 0.1f);
				isAttacking = true;
			}
		}

		if (Input.GetKey(KeyCode.LeftControl)) {
				animator.SetTrigger ("turn");
		}

		if (Input.GetKeyDown("1")) {
			if (isAttacking == false) {
				animator.SetTrigger ("combo1");
				isAttacking = true;
			}
		}

		if (Input.GetKeyDown("2")) {
			animator.SetTrigger ("block");
		}
	}

	public void AttackAnimationOver(){
		isAttacking = false;
	}
}












