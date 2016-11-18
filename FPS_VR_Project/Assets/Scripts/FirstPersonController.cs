using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour {

	private CharacterController _characterController;

	// Use this for initialization
	void Start () {
		_characterController = this.GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		Vector3 _direction;
		_direction = Physics.gravity * 1;
		_characterController.Move (_direction * Time.deltaTime);
	}
}
