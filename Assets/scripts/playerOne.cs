//-------Version2 Simple Movements--------
using UnityEngine;
using System.Collections;

public class playerOne : MonoBehaviour
{
		public int start = 0;
		public float topSpeed = 5.0f;  // Final Speed of the car
		public float btopSpeed = 5.0f;  // Final Speed of the car
		public float currentSpeed = 0.0f; //current speed
		public float acceleration = 2.0f;  //Acceleration of car
		public float deAcceleration = 4.0f;  //Acceleration of car
		public float rotationSpeed = 75.0f;
		public float powerBoostTime = 5.0f;		//How long the power ups last
		public float speedBoost = 10.0f;   //How fast the car is on speed boost

		public Vector2 force;
		public Transform car;
		public float speed;
		public Vector3 trigF;
	
		public float respawnX = 0f;
		public float respawnY = 0f;
		public float[] respawnDistance; 

		private bool speedPower;
		public bool alive = true;
		public bool spawned = false;
	
		// Use this for initialization
		void Start ()
		{
				//keyPressed = false;
				speedPower = false;
				car = this.transform;
		}
	
		// Update is called once per frame
		void  Update ()
		{

			Physics2D.IgnoreLayerCollision (1, 2);
			trigF = car.TransformDirection(Vector3.right);
			force.Set(trigF.x,trigF.y);

			if(Input.GetKey(KeyCode.R)){
				transform.localEulerAngles = new Vector3(0, 0, 0);
			}

			if (Input.GetKey (KeyCode.UpArrow)) {  //Up arrow key - Move right across screen
				speed = speed + (acceleration * Time.deltaTime);
				speed = Mathf.Clamp(speed , -topSpeed, topSpeed);
				rigidbody2D.AddForce(speed*force);
			} 		
			if (Input.GetKey (KeyCode.DownArrow)) {
				speed = speed + (acceleration * Time.deltaTime);
				speed = Mathf.Clamp(speed , -topSpeed, topSpeed);
				rigidbody2D.AddForce(speed*force*-1);
			}
			if (Input.GetKey (KeyCode.RightArrow)){
				transform.Rotate(0f, 0f, -rotationSpeed*Time.deltaTime);
			}
			if (Input.GetKey (KeyCode.LeftArrow)){
				transform.Rotate(0f, 0f, rotationSpeed*Time.deltaTime);
			}
	

				if (speedPower) {
						powerBoostTime -= Time.deltaTime;
						if (powerBoostTime > 0) {
								speedBoost = topSpeed;
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
				if (col.gameObject.name == "SpeedBoost(clone)") {
						speedPower = true;
						Destroy (col.gameObject);
				}
		}
	
		public void checkpointOne ()
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
	
		public void setDeadOne ()
		{
				Debug.Log ("car one dead");
				alive = false;
		}
	
		public void setSpawnedOne ()
		{
				if (alive == false) {
						spawned = true;
				} else {
						spawned = false;
				}
		}
}

