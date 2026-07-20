using UnityEngine;
using UnityEngine.InputSystem;
public class Moving : MonoBehaviour
{
    public float speed = 5f;
    Vector2 movement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3) movement*speed*Time.deltaTime;
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }
}
