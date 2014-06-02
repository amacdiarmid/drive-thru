using UnityEngine;
using System.Collections;

public class characterSelectionSelectionScript : MonoBehaviour {

	public int player1car;
	public int player1character;

	public int player2car;
	public int player2character;

	// Use this for initialization
	void Start () {

		player1car=0;
		player1character=0;
		
		player2car=0;
		player2character=0;
	
	}
	
	// Update is called once per frame
	void Update () {
		DontDestroyOnLoad(this);
	}
}
