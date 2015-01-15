//using UnityEngine;
//using System.Collections;
//
//
//
//public class A_Fish_Transforms : MonoBehaviour {
//
//	public string objectTag1;
//	public string objectTag2;
//	public float rayDistance = 100;
//	public float levelWaitTime = 3.0f;
//
//
//	 
//
//	public AudioClip Bells104;
//	//public AudioClip A_Fish_Sound_2;
//	//public AudioClip A_Fish_Sound_3;
//
//	// Use this for initialization
//	void Start () 
//	{
//	
//	}
//
//
//	// Update is called once per frame
//	void Update () 
//	{
//
//
////		if (Input.GetKey ("escape")) 
////		{
////			Application.Quit ();
////		}
//
//		if (Input.GetMouseButtonDown(0)) 
//		{
////			Debug.Log ("Pressed left click.");
//////			audio.PlayOneShot(Bells104);
//
//			RaycastHit hit;
//			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition); 	// Get mouse position
//
//			if(hit.transform.tag == objectTag1)
//			{
//				Debug.Log ("Hit objectTag1");
//				audio.PlayOneShot(Bells104);
//				transform.Translate(Vector2); 
//
//			}
//
////			if(Physics.Raycast(ray, out hit, rayDistance))  
////			{	
////				if (Physics.Raycast(ray, out hit)) 
////				{
////					if (hit.collider != null)
////					{
////						hit.collider.enabled = false;
////					}
////						
////				}
////						
////			}
//
//
////						transform.Translate (Input.GetAxis ("Horizontal") * .5F, 0F, Input.GetAxis ("Vertical") * .5F); 	
////						transform.Rotate (Input.GetAxis ("Mouse Y") * 3F, -Input.GetAxis ("Mouse X") * 3F, 0F);
//				
//			
//
////		if (Input.GetMouseButtonDown(1))
////			Debug.Log("Pressed right click.");
////		
////		if (Input.GetMouseButtonDown(2))
////			Debug.Log("Pressed middle click.");
//		}
//	}
//}
//
