using UnityEngine;
using System.Collections;

public class A_LetterScript : MonoBehaviour {

	private Animator animator;
	private int State = 0;
	private AudioSource audioSource;
	public AudioClip aPageVoice;

	void Start () 
	{
		//audioSource = this.GetComponent<AudioSource>();
		
		animator = this.GetComponent<Animator>();
		animator.SetInteger ("State", 0);
	}
	
	//	void Update ()
	//	{
	//		if (Input.GetMouseButtonDown(2) && gameObject.tag == "A_BlueFish")
	//		{
	//			Debug.Log("Pressed middle click for Move.");
	//			animator.SetInteger ("State", 3);
	//		}
	//	}
	//	private void OnMouseOver()
	//	{
	//		Debug.Log("Pressed right click for Zoom.");
	//		animator.SetInteger ("State", 2);
	//		StartCoroutine("Wait");
	//	}
	private void OnMouseDown()
	{
		Debug.Log("Pressed right click for Rotate.");
		animator.SetInteger ("State", 1);


		StartCoroutine("Sound");
		StartCoroutine("Wait");
	}
	
	
	IEnumerator Wait () 
	{
		yield return new WaitForSeconds(5f);

		animator.SetInteger ("State", 0);
		
	}
	IEnumerator Sound () 
	{
		yield return new WaitForSeconds(1.2f);
		audio.PlayOneShot(aPageVoice, 0.7F);

		
	}

}
