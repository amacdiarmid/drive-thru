using UnityEngine;
using System.Collections;

public class PlayerTwoCar : MonoBehaviour {
	

	public GameObject car;
	
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

		if(selectCar.GetComponent<characterSelectionSelectionScript>().player2character==1)
		{
			if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==1)
			{
				(Instantiate(guycar1, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==2)
			{
				(Instantiate(guycar2, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==3)
			{
				(Instantiate(guycar3, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;			
			}
		}
		else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2character==2)
		{
			if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==1)
			{
				(Instantiate(megancar1, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;			
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==2)
			{
				(Instantiate(megancar2, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==3)
			{
				(Instantiate(megancar3, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
		}
		else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2character==3)
		{
			if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==1)
			{
				(Instantiate(hamishcar1, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==2)
			{
				(Instantiate(hamishcar2, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==3)
			{
				(Instantiate(hamishcar3, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
		}
		else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2character==4)
		{
			if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==1)
			{
				(Instantiate(robotcar1, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==2)
			{
				(Instantiate(robotcar2, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==3)
			{
				(Instantiate(robotcar3, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
		}
		else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2character==5)
		{
			if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==1)
			{
				(Instantiate(dogcar1, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==2)
			{
				(Instantiate(dogcar2, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==3)
			{
				(Instantiate(dogcar3, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
		}
		else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2character==6)
		{
			if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==1)
			{
				(Instantiate(spidercar1, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==2)
			{
				(Instantiate(spidercar2, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<characterSelectionSelectionScript>().player2car==3)
			{
				(Instantiate(spidercar3, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
