using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour

{
    public Image icon;
    public Button removeButton;
    Item Item;
    public void AddItem(Item newItem) // Adds the picked up item to the inventory slot
    {
        Item = newItem;
        icon.sprite = Item.icon;
        icon.enabled = true;
        removeButton.interactable = true;
    }

    public void ClearSlot() // Removes the item from the corresponding slot
    {
        Item = null;
        icon.sprite = null; 
        icon.enabled = false;
        removeButton.interactable = false;
    }

    public void OnDisableButton() //this is the method for the button function
    {
        Inventory.Instance.Remove(Item);
    }
}
