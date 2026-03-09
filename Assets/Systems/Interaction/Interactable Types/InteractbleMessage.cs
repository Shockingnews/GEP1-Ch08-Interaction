using UnityEngine;

public class InteractbleMessage : MonoBehaviour, IInteractible
{
    public bool debugEnabled = false;
    [SerializeField] private UIManager uiManager;
    

    [SerializeField] string message;

    private void Awake()
    {
        uiManager = ServiceHub.Instance.UIManager;
    }
    public void Focused()
    {

    }

    public void Interact()
    {
        uiManager.DisplayMessage(message);
    }

    public void UnFocused()
    {

    }
}
