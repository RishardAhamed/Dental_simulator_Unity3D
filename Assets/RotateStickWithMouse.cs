using UnityEngine;

public class RotateStickWithMouse : MonoBehaviour
{
    public Transform fixedPoint; // The fixed point around which rotation occurs
    public float rotationSpeed = 2.0f; // Speed of rotation
    public float maxAngle = 90.0f; // Maximum rotation angle

    private Vector3 initialRotation;
    private Vector3 initialMousePosition;

    private void Start()
    {
        initialRotation = transform.eulerAngles;
    }

    private void OnMouseDown()
    {
        initialMousePosition = Input.mousePosition;
    }

    private void OnMouseDrag()
    {
        Vector3 currentMousePosition = Input.mousePosition;
        Vector3 deltaMouse = currentMousePosition - initialMousePosition;

        float angleX = -deltaMouse.y * rotationSpeed;
        float angleY = deltaMouse.x * rotationSpeed;

        // Apply the rotation to the stick's transform
        Vector3 newEulerAngles = initialRotation + new Vector3(angleX, angleY, 0.0f);
        newEulerAngles.x = Mathf.Clamp(newEulerAngles.x, -maxAngle, maxAngle);
        newEulerAngles.y = Mathf.Clamp(newEulerAngles.y, -maxAngle, maxAngle);

        transform.eulerAngles = newEulerAngles;

        // Update the position of the other end of the stick based on the rotation
        Vector3 newPosition = fixedPoint.position + transform.forward * Vector3.Distance(fixedPoint.position, transform.position);
        transform.position = newPosition;

        initialMousePosition = currentMousePosition;
    }
}