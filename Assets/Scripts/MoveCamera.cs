using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;

public class MoveCamera : MonoBehaviour
{
    Camera mainCamera;

    private void Start()
    {
        mainCamera = GetComponent<Camera>();
    }

    public void OnMove(InputAction.CallbackContext callback)
    {
        Vector2 input = callback.ReadValue<Vector2>();
        if(input != null)
        {
            mainCamera.transform.position += new Vector3(input.x, input.y, 0f);
        }
    }

    public void OnTouch(InputAction.CallbackContext callback)
    {
        //https://stackoverflow.com/questions/65681661/how-to-access-the-click-desktop-tap-mobile-position-using-the-new-input-sy
        
        Vector2 input = callback.ReadValue<TouchState>().position;
        TouchState ts = callback.ReadValue<TouchState>();
        if (callback.performed & ts.phase == UnityEngine.InputSystem.TouchPhase.Began) // 터치가 시작되었을 때만 체크
        {
            //Debug.Log(callback.ReadValue<TouchState>().touchId);
            if (input.x > Screen.width * 0.75f && input.y > Screen.height * 0.25f && input.y < Screen.height * 0.75f)
                mainCamera.transform.position += new Vector3(1f, 0f, 0f);
            else if (input.x < Screen.width * 0.25f && input.y > Screen.height * 0.25f && input.y < Screen.height * 0.75f)
                mainCamera.transform.position += new Vector3(-1f, 0f, 0f);
            else if (input.y > Screen.height * 0.75f && input.x > Screen.width * 0.25f && input.x < Screen.width * 0.75f)
                mainCamera.transform.position += new Vector3(0f, 1f, 0f);
            else if (input.y > Screen.height * 0.75f && input.x > Screen.width * 0.25f && input.x < Screen.width * 0.75f)
                mainCamera.transform.position += new Vector3(0f, -1f, 0f);

            Debug.Log(input.x + " / " + input.y);
        }
    }

    public void OnLook(InputAction.CallbackContext callback)
    {
        Vector2 input = callback.ReadValue<Vector2>();
        if (input != null)
        {
            mainCamera.transform.Rotate(0f, input.x * 10f, 0f);
            mainCamera.transform.Rotate(input.y * -10f, 0f, 0f);
        }
    }
}
