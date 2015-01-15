using UnityEngine;
using System.Collections;

public class A_Exit_Button_Script : MonoBehaviour {


	private void OnMouseDown()
	{
		Debug.Log("Pressed right click for Rotate.");
		Application.Quit();

	}


}
