//	OnTouchDown.js
//	Allows "OnMouseDown()" events to work on the iPhone.
//	Attack to the main camera.
 
#pragma strict
//#pragma implicit
//#pragma downcast

function Update()
{
     var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
     var hit : RaycastHit;
     if(Physics.Raycast(ray,hit))
     {
          	if(hit.collider.tag == "A_BlueFish")
      		{
          		Debug.Log("Pressed right click for Zoom.");
               //hit.collider.gameObject now refers to the 
               //cube under the mouse cursor if present
          	}
     }
}



 
//function Update () {
//	// Code for OnMouseDown in the iPhone. Unquote to test.
//	var hit : RaycastHit;
//	var animator: Animator;
//	animator = GetComponent.<Animator>();
//	 
//	for (var i = 0; i < Input.touchCount; ++i) {
//		if (Input.GetTouch(i).phase == TouchPhase.Began && hit.transform.tag == "A_BlueFish") {
//		// Construct a ray from the current touch coordinates
//		var ray = camera.ScreenPointToRay (Input.GetTouch(i).position);
//		if (Physics.Raycast (ray,hit)) {
//			hit.transform.gameObject.SendMessage("OnMouseDown");
//			
//					animator.SetInteger ("State", 3);
//	      }
//	   }
//   }
//}
//function Update ()
//{
//    if ( Input.GetMouseButtonDown(0))
//    {
//        var hit : RaycastHit;
//        var ray : Ray = Camera.main.ScreenPointToRay (Input.mousePosition);
// 
//        if (Physics.Raycast (ray, hit, 100.0))
//        {  
//           // Destroy(GameObject.Find("A_BlueFish_Body"));
//            
//           if (Input.GetMouseButtonDown(1) && gameObject.tag == "A_BlueFish" )
//           {
//			Debug.Log("Pressed right click for Zoom.");
//				animator.SetInteger ("State", 2);
//		 	}
//        }
//    }
//}
//if ( Input.GetMouseButtonDown(0)){
//var hit : RaycastHit;
//var ray : Ray = Camera.main.ScreenPointToRay (Input.mousePosition);
//var select = GameObject.FindWithTag("A_BlueFish_Body").transform;
//if (Physics.Raycast (ray, hit, 100.0)){
//select.tag = "none";
//hit.collider.transform.tag = "A_BlueFish";
//}
//}
