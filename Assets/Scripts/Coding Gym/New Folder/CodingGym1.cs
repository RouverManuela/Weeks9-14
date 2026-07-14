using UnityEngine;
using UnityEngine.InputSystem;

public class CodingGym1 : MonoBehaviour
{

    public float speed;
    private Vector2 movementDirection = Vector2.zero;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3)movementDirection * speed * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementDirection = context.action.ReadValue<Vector2>();
    }
}
