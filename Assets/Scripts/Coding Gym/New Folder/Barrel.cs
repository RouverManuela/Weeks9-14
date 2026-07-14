using UnityEngine;
using UnityEngine.InputSystem;

public class Barrel : MonoBehaviour
{
    //public Vector3 lookRotate = Vector3.zero;
    public float rotateSpeed;
    Vector2 look;

    //Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
      transform.right = look * rotateSpeed * Time.deltaTime;
    }

    public void OnRotate(InputAction.CallbackContext context)
    {
       // transform.right = context.ReadValue<Vector2>();
       look = context.action.ReadValue<Vector2>();
    }
}
