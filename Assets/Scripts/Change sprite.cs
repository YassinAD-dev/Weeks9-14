using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeSprite : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    public Sprite[] sprites;

    int counter = 0;

    void Start()
    {
        spriteRenderer.sprite = sprites[counter];
    }

    public void ChangeSpriteImage(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            counter++;

            if (counter >= sprites.Length)
                counter = 0;

            spriteRenderer.sprite = sprites[counter];
        }
    }
}