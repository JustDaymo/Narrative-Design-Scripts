using UnityEngine;
using Fungus;

public class Third_Person_Movement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public Flowchart flowchart;

    public float speed = 6f;
    public float turnspeed = 0.1f;
    float turnvelocity;

    bool stopPlayer;

    // Update is called once per frame.
    void Update()
    {
        stopPlayer = flowchart.GetBooleanVariable("stopPlayer"); // Sets the stopPlayer variable to match the Fungus variable.

        if (stopPlayer == false)
        {
            float horizontal = Input.GetAxisRaw("Horizontal"); // Looks at the input of the keys and sends back a value between -1 and 1. -1 means left, 1 means right, 0 means no input.
            float vertical = Input.GetAxisRaw("Vertical"); // Same as above but for vertical.
            Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized; // Sets up the "direction" with the current inputs.
            // Normalization means the result of the vector always equals 1, so if left and up are pressed, it doesn't allow the player to get double speed because the result would be 2.

            if (direction.magnitude >= 0.1f) // If our direction vector value has a number above 0.1, aka any time a direction key is pressed.
            {
                float targetangle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y; // Figures out the player's radiance, converts it to degrees
                // and adds the camera's Y angle to figure out where the player should go.
                float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetangle, ref turnvelocity, turnspeed); // Sets an angle float that looks at the current angle, the angle the player is going for
                // and stores it in float. Lastly then looks at a float for how fast it should transition between the angles.
                transform.rotation = Quaternion.Euler(0f, angle, 0f); // Changes the rotation of the player according to the result from above.

                Vector3 movedirection = Quaternion.Euler(0f, targetangle, 0f) * Vector3.forward; // Sets a vector that is set to the angle the player wants to go and makes it go forward.
                controller.Move(movedirection.normalized * speed * Time.deltaTime); // Move in the direction at a speed times by the framerate speed.
            }
        }
    }
}