using UnityEngine;

//Mate attach This Scripte To Camare In Project Windows

public class fly : MonoBehaviour
{
    public float movementSpeed = 5f;  // Speed at which the camera moves
    public float rotationSpeed = 3f;  // Speed at which the camera rotates

    public float movementSpeedOperateMode = 1f;  // Speed at which the camera moves

    public SceneManager sceneManager;

    [SerializeField]
    private bool operateMode;

    void Update()
    {


        if (!sceneManager.ToolMode)
        {

            CameraInputHandler();
        }
    }



    private void CameraInputHandler()
    {

        // Camera movement
        float horizontalMovement = Input.GetAxis("Horizontal");
        float verticalMovement = Input.GetAxis("Vertical");
        float upMovement = Input.GetKey(KeyCode.Space) ? 1f : 0f;
        float downMovement = Input.GetKey(KeyCode.LeftShift) ? -1f : 0f;

        float speed = operateMode ? movementSpeedOperateMode : movementSpeed;
        Vector3 movement = new Vector3(horizontalMovement, upMovement + downMovement, verticalMovement) * speed * Time.deltaTime;
        transform.Translate(movement, Space.Self);




        // Camera rotation
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        transform.Rotate(Vector3.up, mouseX * rotationSpeed, Space.World);
        transform.Rotate(Vector3.left, mouseY * rotationSpeed, Space.Self);

        // Reset Z rotation to zero
        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, 0f);
    }
}
