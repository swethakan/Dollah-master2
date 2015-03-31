#pragma strict


var count = 0; 
function Start () {

}

function Update () {
print(count);
count++;

if (count == 170)
	Application.LoadLevel("Beginning");

}