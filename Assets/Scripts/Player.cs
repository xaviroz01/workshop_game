using UnityEngine;
public class Player : MonoBehaviour
{
    private LayerMask mask;
    private bool isToggled = false;
    void Start()
    {
        mask = LayerMask.GetMask("Interactable");
    }
    void Update()
    {
        Debug.DrawRay(Camera.main.transform.position, Camera.main.transform.forward * 50f, Color.green);
        if(Input.GetMouseButtonDown(0))//GetMouseButtonDown เริ่มจากซ้าย,กลาง,ขวา,นอกนั้นไล่ตามลำดับ
        {
            if(Physics.Raycast(
                Camera.main.transform.position, 
                Camera.main.transform.forward, 
                out RaycastHit hit, 
                50f, 
                mask))
            {
                Debug.Log("Hit someting");
                IInteractable comp = hit.collider.gameObject.GetComponent<IInteractable>();
                comp.Interact();
            }
        }

        if(Input.GetKeyDown(KeyCode.I)){
            isToggled = !isToggled;
            if(isToggled){
                GameManager.instance.OpenInventoryPanel();
            }
            else
            {
                GameManager.instance.CloseInventoryPanel();
            }
        }
        
    }
}
