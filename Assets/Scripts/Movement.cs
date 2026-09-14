using SO;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class Movement : MonoBehaviour
{
    [SerializeField] private MoveSettings _settings;
    [SerializeField] private CharacterController _controller;
    [SerializeField] private CameraControl _cameraControl;

    private void Awake()
    {
        _controller ??= GetComponent<CharacterController>();
    }
    

    void Update()
    {
        float speed = _settings.Speed;
        Vector3 movement = Vector3.zero;
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        if (horizontalInput != 0 || verticalInput != 0)
        {
            movement.x = horizontalInput;
            movement.z = verticalInput;
        }

        movement.Normalize();
        movement *= speed;
        _controller.Move(movement * Time.deltaTime);
    }
}
