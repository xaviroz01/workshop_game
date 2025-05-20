using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public static GameManager instance;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else{
            Destroy(gameObject);
        }
    }

    public InventoryPanel inventoryPanel;

    public void OpenInventoryPanel(){
        Time.timeScale = 0f;
        inventoryPanel.OnOpen();
        inventoryPanel.gameObject.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
    public void CloseInventoryPanel(){
        Time.timeScale = 1f;
        inventoryPanel.gameObject.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
