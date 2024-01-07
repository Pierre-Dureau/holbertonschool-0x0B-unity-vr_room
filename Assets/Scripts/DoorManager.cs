using UnityEngine;

public class DoorManager : MonoBehaviour
{
    [SerializeField] private Animator animator;
    private bool door = true;

    public void OpenDoor() {
        animator.SetBool("character_nearby", door);
        door = !door;
    }
}
