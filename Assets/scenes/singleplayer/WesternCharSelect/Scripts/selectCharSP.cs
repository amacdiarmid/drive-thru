using UnityEngine;
using System.Collections;

public class selectCharSP : MonoBehaviour {
	
	public bool show = false;

	public AudioClip click;

	public GameObject guy;
	public GameObject girl;
	public GameObject old;
	public GameObject dog;
	public GameObject robot;
	public GameObject spider;
	
	public GameObject car1;
	public GameObject car2;
	//public GameObject car3;
	
	void Update()
	{
		if (show == true)
		{
			car1.SetActive(true);
			car2.SetActive(true);
			//car3.SetActive(true);
		}
		else if(show == false)
		{
			car1.SetActive(false);
			car2.SetActive(false);
			//car3.SetActive(false);
		}
	}
	
	void OnMouseEnter()
	{
		renderer.material.color = Color.grey;
		
	}
	
	void OnMouseExit()
	{
		renderer.material.color = Color.white;
	}
	
	void OnMouseUp()
	{
		audio.PlayOneShot(click);

		guy.GetComponent<selectCharSP>().show=false;
		dog.GetComponent<selectCharSP>().show=false;
		girl.GetComponent<selectCharSP>().show=false;
		old.GetComponent<selectCharSP>().show=false;
		robot.GetComponent<selectCharSP>().show=false;

		show = true;
	}
	
}