 #pragma strict
 
 var theTimer : float = 0.0;
 var theStartTime : float = 120.0;
 var showRemaining : boolean = false;
 
 function Start() 
 {
     theTimer = theStartTime;
 }
 
 function Update() 
 {
     theTimer -= Time.deltaTime;
 
 
     if (theTimer < 0) 
     {
         theTimer = 0;
         Application.LoadLevel("Initialisationscene");
     }
 }
 
 function OnGUI() 
 {
     var text : String = String.Format( "{0:00}:{1:00}", parseInt( theTimer / 60.0 ), parseInt( theTimer % 60.0 ) ); 
 
     if (showRemaining)
     {
         GUI.Label( Rect( 10, 10, Screen.width - 20, 30), text );
     }
 }