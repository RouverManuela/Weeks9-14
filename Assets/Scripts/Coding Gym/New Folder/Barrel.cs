using UnityEngine;
using UnityEngine.InputSystem;

public class Barrel : MonoBehaviour
{
   private Vector3 rotationDirection = Vector3.zero;
    //Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
       transform.up += (Vector3)rotationDirection * Time.deltaTime;
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
        Vector2 look = context.ReadValue<Vector2>();

        transform.up = look;
    }
}
