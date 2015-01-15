#pragma strict
//#pragma implicit
//#pragma downcast
									
var A_BlueFish		:String;									
var rayDistance		:float = 400;		// Allows us to adjust the mouse raycast distance
//var Bells104		:AudioClip;


function Start()
{

}    

function Update () 
{
//
//	if (Input.GetKey ("escape")) 
//	{
//		Application.Quit();
//	}
//	
	
	var hit: RaycastHit;
	var ray: Ray = Camera.main.ScreenPointToRay(Input.mousePosition); 	// Get mouse position
	var fwd = transform.TransformDirection (Vector3.forward);
	var animator: Animator;
	 
		
//		if (Physics.Raycast (transform.position, fwd, 400)) 
//		{
//			print ("There is something in front of the object!");
//			
//		}	

	 
			if(Input.GetMouseButtonDown(0) && hit.transform.tag == "A_BlueFish")		//Left mouse button
			{
		
				print("Left mouse down works");
		
				animator = GetComponent.<Animator>(); 
				
				animator.SetInteger ("State", 1);
	    	}
		
		
//				// Cast a Ray against all colliders in the scene
//	 			if(Physics.Raycast(ray, hit, rayDistance))  
//	 			{
//	  		
//	  				if(hit.transform.tag == A_BlueFish)
//	  				{
//					animator = GetComponent.<Animator>(); 
//					animator.SetInteger ("State", 1);
//	  				Debug.Log("Changed STATE from: Idle to Rotate.");
//
//			
//					}
//				}
}