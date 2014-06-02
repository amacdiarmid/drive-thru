// Camera Follow Script
// Mackenzie Reid
// Unnamed Game Group 5
// Side-Scrolling Racer Game
using UnityEngine;
using System.Collections;

public class singlePlayerCamera : MonoBehaviour
{

		public GameObject player1; //object for camera to follow/look-at
		public float smoothTime = 0.1f;  //Time for dampen (smoothness of car movements)
		public bool xAxisFollow = true; //Follow on x-axis
		public bool yAxisFollow = true; //Follow on y-axis
		public Vector3 velocity;  //Speed of camera movements
		public float cameraSize = 15f;
		private Transform thisTransform;  //Camera transform
	
	
		// Use this for initialization
		void Start ()
		{
				thisTransform = transform;
		}

		void Update () 
	{
		player1 = GameObject.FindWithTag("Player");
	}
	
		// Update is called once per frame
		void FixedUpdate ()
		{
				if (xAxisFollow) {
						thisTransform.position = new Vector3 (Mathf.SmoothDamp (thisTransform.position.x, player1.transform.//Get cam to follow x-axis when x-axisFollow is true; 
				                                                      position.x, ref velocity.x, smoothTime), thisTransform.//''''''''''''''
				                                     position.y, thisTransform.position.z);  //''''''''''''''
				}
			
				if (yAxisFollow) {
				
				}
			
				if (yAxisFollow) {
				
				}
		}
}
