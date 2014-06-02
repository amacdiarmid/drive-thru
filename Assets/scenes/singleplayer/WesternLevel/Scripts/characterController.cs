//-------Version2 Simple Movements--------
//-----------Complete 18/2/14------------

using UnityEngine;
using System.Collections;

public class characterController : MonoBehaviour 
{
	
	public float moveSpeed = 18.0f;    //Speed of the car
	public float respawnX = 0f;
	public float respawnY =0f;

	private bool isGrounded;   //Variable to check if car is on ground

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if(isGrounded)  //if car is on the ground
		{
			if(Input.GetKey(KeyCode.UpArrow))  //Up arrow key - Move right across screen
			{
				gameObject.rigidbody2D.AddForce(gameObject.transform.right*moveSpeed);
			}
			if(Input.GetKeyDown(KeyCode.DownArrow))  //Down arrow pressed - Move reduced to 0 for brake
			{
				moveSpeed = 0.0f;
			}
			if(Input.GetKeyUp(KeyCode.DownArrow))  //Returns speed to normal
			{
				moveSpeed = 5.0f;
			}
			if(Input.GetKey(KeyCode.LeftArrow))   //Rotation Left
			{
				transform.Rotate(0,0,30*Time.deltaTime);
			}
			if(Input.GetKey(KeyCode.RightArrow))  //Rotation Left
			{
				transform.Rotate(0,0,-30*Time.deltaTime);
			}
		} 			//End of Ground controls

		if(!isGrounded)   //if car is not grounded
		{
			if(Input.GetKey(KeyCode.UpArrow))  ////Up arrow key - Move right across screen
			{
				gameObject.rigidbody2D.AddForce(gameObject.transform.right*moveSpeed);
			}
			if(Input.GetKeyDown(KeyCode.DownArrow))    //Down arrow pressed - Move reduced to 0 for brake
			{
				moveSpeed = 0.0f;
			}
			if(Input.GetKeyUp(KeyCode.DownArrow)) 	//Returns speed to normal
			{
				moveSpeed = 18.0f;
			}
			if(Input.GetKey(KeyCode.LeftArrow))		//Rotation Left - more than ground controls
			{
				transform.Rotate(0,0,120*Time.deltaTime);  
			}
			if(Input.GetKey(KeyCode.RightArrow))		//Rotation Left - more than ground controls
			{
				transform.Rotate(0,0,-120*Time.deltaTime);  
			}
		}		//End of Air controls
	}
	
	void OnCollisionStay2D(Collision2D col)
	{
		if(col.gameObject.name=="Ground")
		{
			isGrounded = true;
			Debug.Log("Is groudned");
		} 
	}

	void OnCollisionExit2D(Collision2D col)
	{
		if(col.gameObject.name=="Ground")
		{
			isGrounded = false;
			Debug.Log("No longer grounded");
		}
	}


	public void respawn ()
	{
		//write to debug
		Debug.Log ("respawn");
		//stop current movement
		rigidbody2D.velocity = Vector2.zero;
		//reset rotation
		transform.rotation = Quaternion.identity;
		//set position to current respawn values
		transform.position = new Vector2(respawnX,respawnY);

	}

	public void checkpoint ()
	{
		//write to debug
		Debug.Log("checkpoint");
		//set the respawn co ords to current location
		respawnX = transform.position.x;
		respawnY = transform.position.y;
	}
}
