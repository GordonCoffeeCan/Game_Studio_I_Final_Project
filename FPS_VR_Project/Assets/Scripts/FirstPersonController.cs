using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour {
	public Transform mainCamera;
	public float speed = 5;

	private Vector3 _moveDirection;
	private float _gravity = 20;
	private Transform _transfrom;

	private CharacterController _characterController;

	// Use this for initialization
	void Start () {
		_transfrom = this.transform;
		_moveDirection = Vector3.zero;
		_characterController = this.GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		_transfrom.rotation = mainCamera.rotation;
		if (_characterController.isGrounded) {
			_moveDirection = new Vector3 (Input.GetAxis ("Horizontal"), 0, Input.GetAxis ("Vertical"));
			_moveDirection = _transfrom.TransformDirection (_moveDirection);
			_moveDirection *= speed;
		}
		_moveDirection.y -= _gravity * Time.deltaTime;
		_characterController.Move (_moveDirection * Time.deltaTime);
		mainCamera.position = _transfrom.position;
	}
}
