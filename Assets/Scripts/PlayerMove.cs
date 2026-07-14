using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
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
        //If we have a Vector2 and we want to add it to the a Vector3
        //We can convert between them using (Vector3) in front of the Vector2
        transform.position += (Vector3)movementDirection * speed * Time.deltaTime;
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        movementDirection = context.ReadValue<Vector2>();
    }

    public void onAttack(InputAction.CallbackContext context)
    {
        if(context.performed) //before in the cosole it showed when attack was made (button pressed), when it-
                              //-happens and when it is released. this .performed it makes it so the console only shows-
                              //-once when the attack is made rgardless if you hold the button or not 
        {
            Debug.Log("Attack " + context.phase);
        }
        
    }
}