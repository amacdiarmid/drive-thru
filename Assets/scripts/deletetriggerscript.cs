using UnityEngine;
using System.Collections;

public class deletetriggerscript : MonoBehaviour {

	//on collision with object 
	void OnTriggerEnter2D(Collider2D delete){
		if(delete.collider2D.gameObject.tag == "tile")
		{
			Debug.Log("tilecollide");
			Destroy(this.gameObject);
		}
	}
}
