using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputs : MonoBehaviour
{
    public Vector2 look;
    public bool rootUsed;
    public bool shooting;
    public bool cursorLocked = true;


    public void OnLook(InputValue value)
    {
        look = value.Get<Vector2>();
    }

    public void OnShootRoot(InputValue value)
    {
        rootUsed = value.isPressed;
    }

    public void OnShootEnemy(InputValue value)
    {
        shooting = value.isPressed;
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnApplicationFocus(bool hasFocus)
    {
        SetCursorState(cursorLocked);
    }

    private void SetCursorState(bool newState)
    {
        Cursor.lockState = newState ? CursorLockMode.Locked : CursorLockMode.None;
    }
}
