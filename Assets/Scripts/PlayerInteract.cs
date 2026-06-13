using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInteract : MonoBehaviour
{
    private Camera cam;
    [SerializeField]
    private float distance = 5f;
    [SerializeField]
    private LayerMask mask;
    private PlayerUI playerUI;


    // Start is called before first frame update
    void Start()
    {
        
        cam = GetComponent<PlayerLook>().cam;
        playerUI = GetComponent<PlayerUI>();

    }

    void Update()
    {
        playerUI.UpdateText(string.Empty);
        //create a ray at the center of the camera, shooting outwards
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawRay(ray.origin, ray.direction * distance);
        RaycastHit hitInfo;

        if(Physics.Raycast(ray, out hitInfo, distance, mask))
        {
            //Debug.Log("Hit: " + hitInfo.collider.name);

            Interactable interactable =
            hitInfo.collider.GetComponentInParent<Interactable>();

            if(interactable != null)
            {
                playerUI.UpdateText(interactable.promptMessage);

                if (Keyboard.current.eKey.wasPressedThisFrame)
                {
                    interactable.BaseInteract();
                }
            }
        }
    }
}