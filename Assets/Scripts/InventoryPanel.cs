using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryPanel : MonoBehaviour
{
    public Image selectIcon;
    public TMP_Text descriptionText;
    public Transform rightPanelTransform;
    public GameObject itemButtonPrefab;

    public void OnOpen()
    {
        for(int i = rightPanelTransform.childCount - 1; i >= 0; i--)
        {
            Destroy(rightPanelTransform.GetChild(i).gameObject);
        }
        for (int i = 0; i < InventoryManager.Instance.inventoryList.Count; i++)
        {
            GameObject itemButtonObj = Instantiate(itemButtonPrefab, rightPanelTransform);
            ItemButton itemButtonComp = itemButtonObj.GetComponent<ItemButton>();
            itemButtonComp.data = InventoryManager.Instance.inventoryList[i];
            itemButtonComp.icon.sprite = itemButtonComp.data.itemIcon;
            Button button = itemButtonObj.GetComponent<Button>();
            button.onClick.AddListener(()=>{
                selectIcon.sprite = itemButtonComp.data.itemIcon;
                descriptionText.text = itemButtonComp.data.description;
            });
        }
    }
}