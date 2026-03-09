using UnityEngine;

public class Interactble_Pickup : MonoBehaviour, IInteractible
{
    public bool debugEnabled = false;
    public void Focused()
    {

    }

    public void Interact()
    {
        if (debugEnabled) Debug.Log("Interacted with" + gameObject.name);
        Destroy(gameObject);
    }

    public void UnFocused()
    {

    }
}
