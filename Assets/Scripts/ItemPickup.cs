using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Cinemachine;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class ItemPickup : MonoBehaviour
{
    public Item item;

    void OnTriggerEnter2D(Collider2D other)
    {
        // Debug.Log(other.name);
        //finds the script component in the player character which makes it recognize the player 
        //this took some time to figure out...
        PlayerManager player = other.GetComponent<PlayerManager>();
        if (player != null)
        {
            PickUp();
        }
    }

    void PickUp()
    {
        //Debug.Log("Picked up");
        Inventory.Instance.Add(item); //calls the add function on the inventory script to add to the list's item count
        Destroy(gameObject);
    }
}