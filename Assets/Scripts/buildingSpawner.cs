using UnityEngine;
using UnityEngine.InputSystem;
public class buildingSpawner : MonoBehaviour
{
    public GameObject building;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            mousePosition.z = 0;

            Instantiate(building, mousePosition, Quaternion.identity);
        }
        
    }
}
