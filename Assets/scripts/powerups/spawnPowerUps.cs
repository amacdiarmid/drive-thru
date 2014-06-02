using UnityEngine;
using System.Collections;

public class spawnPowerUps : MonoBehaviour {

	public GameObject powerUp;
	public Transform positionOne;
	public Transform positionTwo;
	public Transform positionThree;

	// Use this for initialization
	void Start () {
	
		Instantiate(powerUp, positionOne.position, positionOne.rotation);
		Instantiate(powerUp, positionTwo.position, positionTwo.rotation);
		Instantiate(powerUp, positionThree.position, positionThree.rotation);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
