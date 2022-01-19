using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public Transform itemsParent;
    public GameObject inventoryUI;

    Inventory inventory;
    private InventorySlot[] slots;

    void Start()
    {
        inventory = Inventory.Instance;
        inventory.OnItemChangedCallback += UpdateUI;
        slots = itemsParent.GetComponentsInChildren<InventorySlot>();
    }
    

    void UpdateUI()
    { 
        //updates the UI slot display for however many slots available (4 in this case)
        //also clears a slot when an item is removed
        for (int i = 0; i < slots.Length; i++) 
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
        //Debug.Log("Updating UI");
    }
}