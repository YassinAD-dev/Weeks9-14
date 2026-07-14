using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerInput : MonoBehaviour
{
    public float speed;




    private Vector2 movmentDirection = Vector2.zero;





    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position +=(Vector3) movmentDirection*speed * Time.deltaTime;
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        movmentDirection = context.ReadValue<Vector2>();
    }
    public void OnAttack(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            Debug.Log("Attack!" + context.phase);
        }


    }
}
