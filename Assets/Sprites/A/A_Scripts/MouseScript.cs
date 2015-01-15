using UnityEngine;
using System.Collections;


public class MouseScript : MonoBehaviour 
{

	private Animator animator;
	private int State = 0;


	void Start () 
	{
		animator = this.GetComponent<Animator>();
		animator.SetInteger ("State", 0);
	}


	private void OnMouseDown()
	{
		Debug.Log("Pressed right click for Rotate.");
		animator.SetInteger ("State", 1);
		StartCoroutine("Wait");
	}


	IEnumerator Wait () 
	{
		yield return new WaitForSeconds(0.5f);
		animator.SetInteger ("State", 0);
		
	}


}