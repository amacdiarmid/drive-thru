using UnityEngine;
using System.Collections;

public class CameraSmoothFollow : MonoBehaviour {

	public GameObject player1; //object for camera to follow/look-at
	public GameObject player2; //object for camera to follow/look-at
	public float smoothTime = 0.1f;  //Time for dampen (smoothness of car movements)
	public bool xAxisFollow = true; //Follow on x-axis
	public bool yAxisFollow = true; //Follow on y-axis
	public Vector3 velocity;  //Speed of camera movements

	public float minXPosition = -99999999999.0f; //Minimum x-axis barrier
	public float maxXPosition = 999999999999.0f;  //Maximum x-axis barrier
	public float minYPosition = -9999999999999.0f;  //Minimum y-axis barrier
	public float maxYPosition = 99999999999999.0f;  //Maximum y-axis barrier

	public float cameraSize = 15f;

	private Transform thisTransform;  //Camera transform


	// Use this for initialization
	void Start () {
		thisTransform = transform;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(player1.transform.position.x>=player2.transform.position.x && player1.GetComponentInChildren<playerOne>().alive == true){
			Debug.Log("player 1 lead");
			if(xAxisFollow){
				thisTransform.position = new Vector3(Mathf.SmoothDamp(thisTransform.position.x, player1.transform.  //Get cam to follow x-axis when x-axisFollow is true; 
				                                                      position.x, ref velocity.x, smoothTime), thisTransform.  //''''''''''''''
				                                     position.y, thisTransform.position.z);  //''''''''''''''
			}
			
			if(yAxisFollow){
				
			}
		}
		else if(player1.transform.position.x<player2.transform.position.x && player2.GetComponentInChildren<playerTwo>().alive == true){
			Debug.Log("player 2 lead");
			if(xAxisFollow){
				thisTransform.position = new Vector3(Mathf.SmoothDamp(thisTransform.position.x, player2.transform.  //Get cam to follow x-axis when x-axisFollow is true; 
				                                                      position.x, ref velocity.x, smoothTime), thisTransform.  //''''''''''''''
				                                     position.y, thisTransform.position.z);  //''''''''''''''
			}
			
			if(yAxisFollow){
				
			}
		}
		else{
			Debug.Log("both cars are dead");
		}

		cameraSize = player2.transform.position.y - player1.transform.position.y;

		if(player1.GetComponentInChildren<playerOne>().alive == true && player2.GetComponentInChildren<playerTwo>().alive == true)
		{
			if(cameraSize<15f)
			{
				camera.orthographicSize = 15f;
			}
			else
			{
				camera.orthographicSize = cameraSize;
			}
		}
		else if(player1.GetComponentInChildren<playerOne>().alive == true && player2.GetComponentInChildren<playerTwo>().alive ==false)
		{
			camera.orthographicSize = 15f;
		}
		else if(player1.GetComponentInChildren<playerOne>().alive == false && player2.GetComponentInChildren<playerTwo>().alive ==true)
		{
			camera.orthographicSize = 15f;
		}
	}
}