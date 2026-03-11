using UnityEngine;

public class InteractibleTeleport : MonoBehaviour, IInteractible
{
    [SerializeField] private GameObject player;
    private Vector2 spawn = new Vector2(0,0);
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public void Focused()
    {
        
    }

    public void Interact()
    {
        player.transform.position = spawn;
    }

    public void UnFocused()
    {
        
    }
}
