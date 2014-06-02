using UnityEngine;
using System.Collections;

public class rantilegen : MonoBehaviour {



	public GameObject background;
	public GameObject checkpoint;
	public GameObject city1;
	public GameObject city2;
	public GameObject city3;
	public GameObject city4;
	public GameObject city5;
	public GameObject western1;
	public GameObject western2;
	public GameObject western3;
	public GameObject western4;
	public GameObject western5;
	public GameObject space1;
	public GameObject space2;
	public GameObject space3;
	public GameObject space4;
	public GameObject space5;

	public float spawnx = 0;
	public float spawny = 0;

	public int maxtilecount = 3;

	public int tilecount = 3;

	public int temprannum = 0;
	public int tempbackground = 0;

	public float[] tileDistance = new float[3];
	public int I = 0;
	public float tileSize;

	void Awake()
	{
		spawnx = checkpoint.renderer.bounds.size.x/2;
		spawny = 0;
		I = 0;
	}

	public void spawntiles ()
	{
		tempbackground = (Random.Range(1,3));
		if(tempbackground == 1)
		{
			background.GetComponent<backgroundsChanger>().setCity();

			do
			{
				temprannum = (Random.Range(1,5));
				if(temprannum == 1)
				{
					spawnx = spawnx + city1.renderer.bounds.size.x/2;
					Instantiate(city1,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + city1.renderer.bounds.size.x/2;
					tileSize = city1.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
				else if(temprannum == 2)
				{
					spawnx = spawnx + city2.renderer.bounds.size.x/2;
					Instantiate(city2,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + city2.renderer.bounds.size.x/2;
					tileSize = city2.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
				else if(temprannum == 3)
				{
					spawnx = spawnx + city3.renderer.bounds.size.x/2;
					Instantiate(city3,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + city3.renderer.bounds.size.x/2;
					tileSize = city3.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
				else if(temprannum == 4)
				{
					spawnx = spawnx + city4.renderer.bounds.size.x/2;
					Instantiate(city4,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + city4.renderer.bounds.size.x/2;

					tileSize = city5.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
				else if(temprannum == 5)
				{
					spawnx = spawnx + city5.renderer.bounds.size.x/2;
					Instantiate(city5,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + city5.renderer.bounds.size.x/2;
					tileSize = city5.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
			}while(tilecount != 0);
			spawnx = spawnx + checkpoint.renderer.bounds.size.x/2;
			Instantiate(checkpoint,new Vector2(spawnx,spawny),Quaternion.identity);
			tilecount = 3;
			spawnx = spawnx + checkpoint.renderer.bounds.size.x/2;
			I = 0;
		}
		else if(tempbackground ==2)
		{
			background.GetComponent<backgroundsChanger>().setDesert();

			do
			{
				temprannum = (Random.Range(1,maxtilecount));
				if(temprannum == 1)
				{
					spawnx = spawnx + western1.renderer.bounds.size.x/2;
					Instantiate(western1,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + western1.renderer.bounds.size.x/2;
					tileSize = western1.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
				else if(temprannum == 2)
				{
					spawnx = spawnx + western2.renderer.bounds.size.x/2;
					Instantiate(western2,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + western2.renderer.bounds.size.x/2;
					tileSize = western2.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
				else if(temprannum == 3)
				{
					spawnx = spawnx + western3.renderer.bounds.size.x/2;
					Instantiate(western3,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + western3.renderer.bounds.size.x/2;
					tileSize = western3.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
				else if(temprannum == 4)
				{
					spawnx = spawnx + western4.renderer.bounds.size.x/2;
					Instantiate(western4,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + western4.renderer.bounds.size.x/2;
					tileSize = western4.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
				else if(temprannum == 5)
				{
					spawnx = spawnx + western5.renderer.bounds.size.x/2;
					Instantiate(western5,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + western5.renderer.bounds.size.x/2;
					tileSize = western5.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
			}while(tilecount != 0);
			spawnx = spawnx + checkpoint.renderer.bounds.size.x/2;
			Instantiate(checkpoint,new Vector2(spawnx,spawny),Quaternion.identity);
			tilecount = 3;
			spawnx = spawnx + checkpoint.renderer.bounds.size.x/2;
			I = 0;
		}
		else if(tempbackground ==3)
		{
			background.GetComponent<backgroundsChanger>().setSpace();

			do
			{
				temprannum = (Random.Range(1,maxtilecount));
				if(temprannum == 1)
				{
					spawnx = spawnx + space1.renderer.bounds.size.x/2;
					Instantiate(space1,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + space1.renderer.bounds.size.x/2;
					tileSize = space1.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
				else if(temprannum == 2)
				{
					spawnx = spawnx + space2.renderer.bounds.size.x/2;
					Instantiate(space2,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + space2.renderer.bounds.size.x/2;
					tileSize = space2.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
				else if(temprannum == 3)
				{
					spawnx = spawnx + space3.renderer.bounds.size.x/2;
					Instantiate(space3,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + space3.renderer.bounds.size.x/2;
					tileSize = space3.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
				else if(temprannum == 4)
				{
					spawnx = spawnx + space4.renderer.bounds.size.x/2;
					Instantiate(space4,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + space4.renderer.bounds.size.x/2;

					tileSize = space4.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
				else if(temprannum == 5)
				{
					spawnx = spawnx + space5.renderer.bounds.size.x/2;
					Instantiate(space5,new Vector2(spawnx,spawny),Quaternion.identity);
					tilecount --;
					spawnx = spawnx + space5.renderer.bounds.size.x/2;

					tileSize = space5.renderer.bounds.size.x;
					tileDistance[I] = tileSize;
					I++;
				}
			}while(tilecount != 0);
			spawnx = spawnx + checkpoint.renderer.bounds.size.x/2;
			Instantiate(checkpoint,new Vector2(spawnx,spawny),Quaternion.identity);
			tilecount = 3;
			spawnx = spawnx + checkpoint.renderer.bounds.size.x/2;
			I = 0;
		}


	}
}
