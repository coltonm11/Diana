#pragma strict




var speed : float = 6.0;
// var jumpSpeed : float = 8.0;
var gravity : float = 20.0;

private var moveDirection : Vector3 = Vector3.zero;

function Update () {
    var controller : CharacterController = GetComponent.<CharacterController>();
    if (controller.isGrounded) {

        moveDirection = Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        moveDirection = transform.TransformDirection(moveDirection);

        moveDirection *= speed;
    }

    moveDirection.y -= gravity * Time.deltaTime;

    controller.Move(moveDirection*Time.deltaTime);
}
