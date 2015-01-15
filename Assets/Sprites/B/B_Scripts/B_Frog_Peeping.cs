using UnityEngine;
using System.Collections;

public class B_Frog_Peeping : MonoBehaviour {

	private Animator animator;
	private int State = 0;
	private AudioSource audioSource;
	public AudioClip bPageFrog;


	void Start () 
	{
		animator = this.GetComponent<Animator>();
		animator.SetInteger ("State", 0);
	}

	void Update() 
	{

//		if (Input.GetMouseButtonDown(0)) 
//		{
//			RaycastHit hit;
//			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//			if (Physics.Raycast(ray, out hit))
//				if (hit.collider != null)
//					hit.collider.enabled = false;
//			Debug.Log("Left mouse button");
//			animator.SetInteger ("State", 1);
//			audio.PlayOneShot(bPageFrog, 0.7F);
//			StartCoroutine("Wait");
//			
//		}

	}

//	IEnumerator Wait () 
//	{
//			yield return new WaitForSeconds (2.3f);
//			animator.SetInteger ("State", 0);
//	}




	void OnTouchDown()
	{
		Debug.Log("Left mouse button Down");
		animator.SetInteger ("State", 1);
		audio.PlayOneShot(bPageFrog, 0.7F);

	}

	void OnTouchUp()
	{
		Debug.Log("Left mouse button Up");
		animator.SetInteger ("State", 0);
		audio.PlayOneShot(bPageFrog, 0.7F);
		
	}

	void OnTouchStay()
	{
		
		
	}

	void OnTouchExit()
	{
		
		
	}
}
