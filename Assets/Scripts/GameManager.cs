using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour 
{

	public GameObject Cursor;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
//		
		Cursor.transform.position = new Vector3(Input.mousePosition.x - (Screen.width/2),Input.mousePosition.y - (Screen.height/2),0);
	}
}
