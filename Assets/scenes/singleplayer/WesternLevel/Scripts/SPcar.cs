﻿using UnityEngine;
using System.Collections;

public class SPcar : MonoBehaviour {
	

	public GameObject car;
	
	public GameObject guycar1;
	public GameObject guycar2;

	public GameObject megancar1;
	public GameObject megancar2;

	public GameObject hamishcar1;
	public GameObject hamishcar2;

	public GameObject robotcar1;
	public GameObject robotcar2;

	public GameObject dogcar1;
	public GameObject dogcar2;

	public GameObject spidercar1;
	public GameObject spidercar2;

	// Use this for initialization
	void Start () {

		GameObject selectCar = GameObject.Find("CharacterSpawner");

		if(selectCar.GetComponent<charSelectionSP>().player1character==1)
		{
			if(selectCar.GetComponent<charSelectionSP>().player1car==1)
			{
				(Instantiate(guycar1, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<charSelectionSP>().player1car==2)
			{
				(Instantiate(guycar2, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
		}
		else if(selectCar.GetComponent<charSelectionSP>().player1character==2)
		{
			if(selectCar.GetComponent<charSelectionSP>().player1car==1)
			{
				(Instantiate(megancar1, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<charSelectionSP>().player1car==2)
			{
				(Instantiate(megancar2, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
		}
		else if(selectCar.GetComponent<charSelectionSP>().player1character==3)
		{
			if(selectCar.GetComponent<charSelectionSP>().player1car==1)
			{
				(Instantiate(hamishcar1, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<charSelectionSP>().player1car==2)
			{
				(Instantiate(hamishcar2, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
		}
		else if(selectCar.GetComponent<charSelectionSP>().player1character==4)
		{
			if(selectCar.GetComponent<charSelectionSP>().player1car==1)
			{
				(Instantiate(robotcar1, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<charSelectionSP>().player1car==2)
			{
				(Instantiate(robotcar2, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
		}
		else if(selectCar.GetComponent<charSelectionSP>().player1character==5)
		{
			if(selectCar.GetComponent<charSelectionSP>().player1car==1)
			{
				(Instantiate(dogcar1, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<charSelectionSP>().player1car==2)
			{
				(Instantiate(dogcar2, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
		}
		else if(selectCar.GetComponent<charSelectionSP>().player1character==6)
		{
			if(selectCar.GetComponent<charSelectionSP>().player1car==1)
			{
				(Instantiate(spidercar1, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
			else if(selectCar.GetComponent<charSelectionSP>().player1car==2)
			{
				(Instantiate(spidercar2, new Vector2(car.transform.position.x,car.transform.position.y),Quaternion.identity)as GameObject).transform.parent = car.transform;
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
