#pragma strict

function Start () {

}

function Update () {


}

function OnCollisionEnter2D(other: Collision2D) {
 
     if(other.gameObject.tag == "player")
     {
         DontDestroyOnLoad(other.gameObject);
       Application.LoadLevel("gameplay");
     }
 }