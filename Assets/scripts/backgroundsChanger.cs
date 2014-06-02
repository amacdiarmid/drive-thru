using UnityEngine;
using System.Collections;

public class backgroundsChanger : MonoBehaviour {
	
	public GameObject desert;
	public GameObject city;
	public GameObject space;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setDesert()
	{
		desert.SetActive(true);
		city.SetActive(false);
		space.SetActive(false);
	}

	public void setCity()
	{
		city.SetActive(true);
		desert.SetActive(false);
		space.SetActive(false);
	}

	public void setSpace()
	{
		space.SetActive(true);
		desert.SetActive(false);
		city.SetActive(false);
	}
}
