using UnityEngine;
using UnityEngine.InputSystem;

public class CodingGym1 : MonoBehaviour
{

    public float speed;
    private Vector2 movementDirection = Vector2.zero;

    public float rotationSpeed;
    private Vector3 lookDirection = Vector3.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movementDirection * speed * Time.deltaTime;
        transform.eulerAngles += lookDirection * rotationSpeed * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementDirection = context.action.ReadValue<Vector2>();
    }

    public void OnLook(InputAction.CallbackContext context)
    {
        lookDirection.z = context.action.ReadValue<Vector2>().x;
    }
}
