#pragma strict
static var WindowSwitch:boolean = false;
var mySkin : GUISkin;
var windowRect = Rect (200, 80, 240, 100);


function OnGUI () 
{ 
	if(WindowSwitch == true) 
	{ 
		GUI.skin = mySkin; 
		windowRect = GUI.Window (0, windowRect, WindowContain, "你几舍的啊？!"); 
	}
}

//}
 function WindowContain (windowID : int) 
   {
       if (GUI.Button (Rect (70,40,100,20), "快领取快递吧！")) 
      { 
         WindowSwitch = false; 
      } 
   } 


function OnMouseEnter () 
{ renderer.material.color = Color.red;
}

/*var X1 = 44.0f;
var X2 = 47.0f;
var Y1 = 54.8f;
var Y2 = 57.3f;
var startTime:float;
var elapse:float;*/


 function OnMouseDown ()
{ WindowSwitch =true;
}
function OnMouseExit ()
{ renderer.material.color = Color.white;
}
/*function Update()
{
   var TRUE = this.transform.position.x > X1 && this.transform.position.x < X2 
		&& this.transform.position.z > Y1 && this.transform.position.z < Y2;
	if(TRUE == true){
		Debug.Log("sdads");
		//startTime = Time.time;
		WindowSwitch = true;
		//Min Move Distance =0.3;
	}
	if(WindowSwitch== true){
		elapse = Time.time - startTime;
		if(elapse > 7){
		WindowSwitch = false;
		elapse=0;
		//Min Move Distance =0;
		}
	}
	/*else{
		elapse = 0;
	}
	if(elapse > 5){
		WindowSwitch = false;
	}*/



