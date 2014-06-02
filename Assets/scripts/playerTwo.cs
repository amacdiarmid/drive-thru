//-------Version2 Simple Movements--------
//-----------Complete 18/2/14------------
//modded version of v2
//creating the 2 player mode
//-------Version2 Simple Movements--------
using UnityEngine;
using System.Collections;

public class playerTwo : MonoBehaviour 
{
	public int start = 0;
	public float initialSpeed = 0f;  //Start speed of car
	public float topSpeed = 5.0f;  // Final Speed of the car
	public float btopSpeed = 5.0f;  // Final Speed of the car
	public float currentSpeed = 0.0f; //current speed
	public float acceleration = 2.0f;  //Acceleration of car
	public float deAcceleration = 4.0f;  //Acceleration of car
	public float groundRotate = 30.0f;   //Rotation on ground
	public float airRotate = 180.0f;   	//Rotation in air
	public float powerBoostTime = 5.0f;		//How long the power ups last
	public float speedBoost = 10.0f;   //How fast the car is on speed boost
	
	public float respawnX = 0f;
	public float respawnY = 0f;
	public float[] respawnDistance; 
	
	//public bool isGrounded;   //Variable to check if car is on ground
	//private bool keyPressed; 
	
	private bool speedPower;
	public bool alive = true;
	public bool spawned = false;
	
	// Use this for initialization
	void Start ()
	{
		//keyPressed = false;
		speedPower = false;
	}
	
	// Update is called once per frame
	void  Update ()
	{
		
		Physics2D.IgnoreLayerCollision (1, 2);
		
		if (Input.GetKey (KeyCode.W)) {  //Up arrow key - Move right across screen
			currentSpeed = currentSpeed + (acceleration * Time.deltaTime);
			gameObject.rigidbody2D.AddForce (gameObject.transform.right * currentSpeed * 1);
			currentSpeed = Mathf.Clamp (currentSpeed, -topSpeed, topSpeed);
		} 		
		if (Input.GetKey (KeyCode.W)) {
			
		}
		if (Input.GetKey (KeyCode.A)) {		//Rotation Left - more than ground controls
			transform.Rotate (0, 0, groundRotate * Time.deltaTime);  
		}
		if (Input.GetKey (KeyCode.D)) {		//Rotation Left - more than ground controls
			transform.Rotate (0, 0, -groundRotate * Time.deltaTime);  
		}
		if (Input.GetKey (KeyCode.S)) {
			currentSpeed = currentSpeed + (acceleration * Time.deltaTime);
			gameObject.rigidbody2D.AddForce (gameObject.transform.right * currentSpeed * -1);
			currentSpeed = Mathf.Clamp (currentSpeed, initialSpeed, topSpeed);
		}
		
		if (speedPower) {
			powerBoostTime -= Time.deltaTime;
			if (powerBoostTime > 0) {
				currentSpeed = topSpeed;
			} else {
				topSpeed = btopSpeed;
				speedPower = false;
				powerBoostTime = 5;
			}
		}
		
		if (alive == false && spawned == true) {				
			//write to debug
			Debug.Log ("respawn");
			//stop current movement
			rigidbody2D.velocity = Vector2.zero;
			//reset rotation
			transform.rotation = Quaternion.identity;
			//set position to current respawn values
			transform.position = new Vector2 (respawnX, respawnY);
			alive = true;
			spawned = false;
		}
		
	}
	
	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.name == "speedBoost") {
			speedPower = true;
			Destroy (col.gameObject);
		}
	}
	
	public void checkpointTwo ()
	{
		//write to debug
		Debug.Log ("checkpoint");
		
		if (start == 1) {
			//set the respawn co ords to current location
			
			respawnDistance = GameObject.Find ("ran tile gen").GetComponent<rantilegen> ().tileDistance;
			
			if (alive == true) {
				respawnX = respawnX + respawnDistance [0] + respawnDistance [1] + respawnDistance [2] + respawnDistance [2];
				//respawnY = respawnY;
			} else {
				respawnX = respawnX + respawnDistance [0] + respawnDistance [1] + respawnDistance [2] + respawnDistance [2];
			}
		} else {
			start = 1;
		}
	}
	
	public void setDeadTwo ()
	{
		Debug.Log ("car Two dead");
		alive = false;
	}
	
	public void setSpawnedTwo ()
	{
		if (alive == false) {
			spawned = true;
		} else {
			spawned = false;
		}
	}
}