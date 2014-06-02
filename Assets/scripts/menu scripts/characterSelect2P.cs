using UnityEngine;
using System.Collections;

public class characterSelect2P : MonoBehaviour {

	public AudioClip click;

	public bool show = false;

	public GameObject guy;
	public GameObject girl;
	public GameObject old;
	public GameObject dog;
	public GameObject robot;
	public GameObject spider;

	public GameObject car1;
	public GameObject car2;
	public GameObject car3;

	void Update()
	{
		if (show == true)
		{
			car1.SetActive(true);
			car2.SetActive(true);
			car3.SetActive(true);
		}
		else if(show == false)
		{
			car1.SetActive(false);
			car2.SetActive(false);
			car3.SetActive(false);
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

		guy.GetComponent<characterSelect2P>().show=false;
		girl.GetComponent<characterSelect2P>().show=false;
		old.GetComponent<characterSelect2P>().show=false;
		dog.GetComponent<characterSelect2P>().show=false;
		robot.GetComponent<characterSelect2P>().show=false;
		spider.GetComponent<characterSelect2P>().show=false;
		show = true;
	}

}
