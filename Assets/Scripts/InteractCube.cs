using UnityEngine;

[RequireComponent(typeof(Renderer))]
public class InteractCube : MonoBehaviour , IInteractable
{
    [SerializeField] private Renderer _renderer;
    
    [SerializeField] private Material _material;
    [SerializeField] private Material _materialInteract;
    [SerializeField] private Material _materialHover;

    private bool _interactActive = false;

    private void Awake()
    {
        _renderer ??= GetComponent<Renderer>();
    }

    public void Interact()
    {
        _renderer.material = _materialInteract;
        _interactActive = true;
    }

    public void Hover()
    {
        if (_interactActive) return;
        _renderer.material = _materialHover; 
    }

    public void UnHover()
    {
        if (_interactActive) return;
        Reset();
    }

    public void Reset()
    {
        _renderer.material = _material;
    }
}
public interface IInteractable
{
    void Interact();
    void Hover();
    void UnHover();

}
