#pragma strict

var micController:GameObject;
var amplify:int;
var decreaseHeight:int;



function Start(){

}

function Update () {

    //Calls the loudness value of selected controller (in this case the controller in micController variable).
    //var thrust=micController.GetComponent(MicControl).loudness;
    //Use this in your script to call loudnes data from selected controller 
    var thrust: float = micController.GetComponent(MicControl).loudness;

    //for each rigidbody, add force through loudness. This will mimic blowing objects away, like a super hero!
    var obj:Rigidbody[]= FindObjectsOfType(Rigidbody);

    var tajm = Time.time;

    //Debug.Log(tajm);

    if(tajm > 7){
    for(var rb:Rigidbody in obj){
            rb.AddForce(transform.right * (thrust*amplify));

            rb.AddForce(transform.up * (thrust/decreaseHeight*amplify));

            rb.transform.position = Vector3(transform.position.x, transform.position.y, transform.position.z);
        //Mathf.Clamp(transform.position.y, -20, 7)
           /* var x = GetComponent.<Rigidbody>().position.y;
            if(x < 9){
                rb.AddForce(transform.up * (thrust*amplify/8));
            }
		*/
    }
}
		
	
}
