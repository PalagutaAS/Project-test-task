using UnityEngine;

public class Interact : MonoBehaviour
{
    [SerializeField] private CameraControl _cameraControl;
    [SerializeField] private string _tag;
    private IInteractable _interactable;
    private void Update()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        
        if (Physics.Raycast(ray, out hit, 3f))
        {
            IInteractable interactable = hit.transform.GetComponent<IInteractable>();

            if (interactable != null)
            {
                _interactable = interactable;
                _interactable.Hover();
            }
            
            if (Input.GetKeyDown(KeyCode.E))
            {
                _interactable.Interact();
            }
        }
        else
        {
            if (_interactable != null)
            {
                _interactable.UnHover();
                _interactable = null;
            } 
        }
    }
}
