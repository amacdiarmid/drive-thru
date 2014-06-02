using UnityEngine;
using System.Collections;

public class PlayerOneCar : MonoBehaviour {

	public Transform spawn;
	
	public GameObject guycar1;
	public GameObject guycar2;
	public GameObject guycar3;

	public GameObject megancar1;
	public GameObject megancar2;
	public GameObject megancar3;

	public GameObject hamishcar1;
	public GameObject hamishcar2;
	public GameObject hamishcar3;

	public GameObject robotcar1;
	public GameObject robotcar2;
	public GameObject robotcar3;

	public GameObject dogcar1;
	public GameObject dogcar2;
	public GameObject dogcar3;

	public GameObject spidercar1;
	public GameObject spidercar2;
	public GameObject spidercar3;
	

	// Use this for initialization
	void Start () {

		GameObject selectCar = GameObject.Find("character spawner");

		if(selectCar.GetComponent<characterSelectionSelectionScript>().player1character==1)
		{
			if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==1)
			{
				Instantiate(guycar1, spawn.position, spawn.rotation);
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==2)
			{
				Instantiate(guycar2, spawn.position, spawn.rotation);
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==3)
			{
				Instantiate(guycar3, spawn.position, spawn.rotation);
			}
		}
		else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1character==2)
		{
			if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==1)
			{
				Instantiate(megancar1, spawn.position, spawn.rotation);
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==2)
			{
				Instantiate(megancar2, spawn.position, spawn.rotation);
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==3)
			{
				Instantiate(megancar3, spawn.position, spawn.rotation);
			}
		}
		else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1character==3)
		{
			if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==1)
			{
				Instantiate(hamishcar1, spawn.position, spawn.rotation);
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==2)
			{
				Instantiate(hamishcar2, spawn.position, spawn.rotation);
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==3)
			{
				Instantiate(hamishcar3, spawn.position, spawn.rotation);
			}
		}
		else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1character==4)
		{
			if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==1)
			{
				Instantiate(robotcar1, spawn.position, spawn.rotation);
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==2)
			{
				Instantiate(robotcar2, spawn.position, spawn.rotation);
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==3)
			{
				Instantiate(robotcar3, spawn.position, spawn.rotation);
			}
		}
		else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1character==5)
		{
			if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==1)
			{
				Instantiate(dogcar1, spawn.position, spawn.rotation);
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==2)
			{
				Instantiate(dogcar2, spawn.position, spawn.rotation);
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==3)
			{
				Instantiate(dogcar3, spawn.position, spawn.rotation);
			}
		}
		else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1character==6)
		{
			if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==1)
			{
				Instantiate(spidercar1, spawn.position, spawn.rotation);
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==2)
			{
				Instantiate(spidercar2, spawn.position, spawn.rotation);
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player1car==3)
			{
				Instantiate(spidercar3, spawn.position, spawn.rotation);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
