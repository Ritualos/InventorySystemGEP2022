using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    //this delegate void gets called whenever an item gets either added or removed on the inventory list
    public delegate void OnItemChanged();

    public OnItemChanged OnItemChangedCallback;

    // a singleton instance makes calling this script from other scripts easier

    #region Singleton

    public static Inventory Instance;

    void Awake()
    {
        if (Instance != null)
        {
            Debug.LogWarning("More than one Inventory instance found");
            return;
        }

        Instance = this;
    }

    #endregion

    //making a list that counts the number of items (scriptable objects) that have been picked up 
    public List<Item> items = new List<Item>();


    public void Add(Item item) //adds to the item count
    {
        items.Add(item);

        if (OnItemChangedCallback != null)
            OnItemChangedCallback.Invoke();
    }

    public void Remove(Item item) //removes from the item count
    {
        items.Remove(item);

        if (OnItemChangedCallback != null)
            OnItemChangedCallback.Invoke();
    }
}