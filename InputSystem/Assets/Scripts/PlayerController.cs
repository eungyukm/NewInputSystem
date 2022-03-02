using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour, ActionMap.IPlayerActions
{
    Vector3 moveVec;
    private ActionMap _inputActions;

    private void OnEnable()
    {
        if(_inputActions == null)
        {
            _inputActions = new ActionMap();
        }
        _inputActions.Player.SetCallbacks(this);
        _inputActions.Player.Enable();
    }

    private void OnDisable()
    {
        _inputActions.Player.Disable();
    }

    public void OnJump()
    {
        Debug.Log("OnJump Call!!");
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        Debug.Log("Move Call!!");
    }

    public void OnWASD(InputAction.CallbackContext context)
    {
        Debug.Log("WASD Call!!");
    }

    public void OnJump(InputAction.CallbackContext context)
    {
        Debug.Log("Jump Call!!");
    }
}
