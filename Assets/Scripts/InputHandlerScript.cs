//using UnityEngine;
//using System.Collections;
//
//public class InputHandlerScript : MonoBehaviour 
//{
//
//	// Use this for initialization
//	void Start () 
//	{
//	
//	}
//	
//	// Update is called once per frame
//	void Update () 
//	{
//
//		if (Input.GetMouseButton (0)) {
//				
//			Ray ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);
//			RaycastHit rayCastHit;
//
//			if (Physics.Raycast(ray.origin, ray.direction, out rayCastHit, Mathf.Infinity));
//			{
//
//				Debug.Log ("Mouse Click");
//				A_BlueFish_Body BlueFishRotate = rayCastHit.transform.GetComponent<A_BlueFishRotate>();
//					
//				if(BlueFishRotate)
//				{
//					BlueFishRotate.PlayBlueFishRotate();
//
//				}
//			}
//
//
//		}
//	
//	}
//}
