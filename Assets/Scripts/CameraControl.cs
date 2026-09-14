using SO;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField] private CameraSettings _cameraSettings;
    [SerializeField] private Camera _camera;
    [SerializeField] private CharacterController _controller;

    private Vector2 _mouseLook;

    public Vector3 LookDirection => _mouseLook.normalized;
    
    private void Awake()
    {
        _camera ??= Camera.main;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        float axisRawX = Input.GetAxisRaw("Mouse X");
        float axisRawY = Input.GetAxisRaw("Mouse Y");
        
        Vector2 mouseInputs = new Vector2 (axisRawX, axisRawY) * _cameraSettings.Sensitivity;
        _mouseLook += mouseInputs;
        _mouseLook.y = Mathf.Clamp (_mouseLook.y, -90f, 90f);
        
        transform.localRotation = Quaternion.AngleAxis (-_mouseLook.y, Vector3.right);
        _controller.transform.localRotation = Quaternion.AngleAxis (_mouseLook.x, _controller.transform.up);
    }
}
