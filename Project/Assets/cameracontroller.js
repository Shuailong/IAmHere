#pragma strict

function Start () {

}

function Update () {

    var zoom:float = Input.GetAxis("Mouse ScrollWheel");
    var dx:float = Input.GetAxis("Mouse X");
    var dy:float = Input.GetAxis("Mouse Y");
    
    this.transform.Translate(Vector3.forward*zoom);
    
    if(Input.GetMouseButton(1))
    {
    this.transform.Rotate(new Vector3(-dy,-dx,0));
    }

}