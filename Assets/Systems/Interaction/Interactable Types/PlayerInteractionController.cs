using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteractionController : MonoBehaviour
{
    public bool debugEnabled = false;
    [SerializeField] private IInteractible targetInteraction;

    [SerializeField] private GameObject debugCurrentInteraction;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.TryGetComponent(out IInteractible foundInteractble))
        {
            targetInteraction = foundInteractble;
            debugCurrentInteraction = other.gameObject;
            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.TryGetComponent(out IInteractible foundInteractble))
        {
            targetInteraction = null;
            debugCurrentInteraction = null;
        }
    }

    // When interact input is pressed call this

    public void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            if(targetInteraction != null)
            {
                if (debugEnabled) Debug.Log("Interacting");

                targetInteraction.Interact();
            }

            
        }
       
    }
}
