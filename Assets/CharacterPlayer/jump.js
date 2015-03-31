#pragma strict

var isgrounded : boolean = true;
var anim : Animator;
var jump : int = Animator.StringToHash("jump");
var still : int = Animator.StringToHash("still");
var isGrounded = false;

function Awake () {

	}

function Update ()
{
	/*if(Input.GetKey (KeyCode.A))
	{
		transform.position.x -= 0.1;
	}
	if(Input.GetKey (KeyCode.D))
	{
		transform.position.x += 0.1;
	}*/
	if (Input.GetKey (KeyCode.UpArrow) && isgrounded == true)
	{
		anim.SetTrigger (jump);
		print("JUMP");
		isGrounded = false;
	}
	else 
	{
		anim.SetTrigger (still);

	}
}
function OnCollisionEnter(theCollision : Collision)
{
print("UANDICOLLIDING!!!");

	if(theCollision.gameObject.tag == "ground")
	{
	print("ONGROUND!!!");
		isgrounded = true;
		anim.SetTrigger (still);
	}
}
