using UnityEngine;

public class ItemBese : MonoBehaviour, IInteractable
{
    public ItemData data;

    public void Interact()
    {
        Debug.Log("interact item: " + data.name);
        InventoryManager.Instance.AddItem(data);
        Destroy(gameObject);
    }
}
