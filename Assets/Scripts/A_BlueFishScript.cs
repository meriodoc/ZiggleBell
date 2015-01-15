using UnityEngine;
using System.Collections;


public class A_BlueFishScript : MonoBehaviour 
{

	public AudioClip Bells104;


	private Animator animator;
	private int State = 0;
	private AudioSource audioSource;


	void Start () 
	{
		animator = this.GetComponent<Animator>();
		animator.SetInteger ("State", 0);
	}

	void Update () 
	{

		if (Input.GetMouseButtonDown (0) && gameObject.tag == "A_BlueFish") 
		{
						Debug.Log ("Pressed left click for Rotate.");
						animator.SetInteger ("State", 1);
						StartCoroutine("Wait");

		}		
		
		if (Input.GetMouseButtonDown (1) && gameObject.tag == "A_BlueFish") 
		{
						Debug.Log ("Pressed right click for Zoom.");
						animator.SetInteger ("State", 2);
						StartCoroutine("Wait");
		}

		if (Input.GetMouseButtonDown(2) && gameObject.tag == "A_BlueFish")
		{
			Debug.Log("Pressed middle click for Move.");
				animator.SetInteger ("State", 3);
		}
	}

	IEnumerator Wait () 
	{
		yield return new WaitForSeconds(1.2f);
		animator.SetInteger ("State", 0);

	}

}