using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] int itemCount = 0;
    private void OnEnable()
    {
        Collectible.onCollected += AddItem;
    }
    private void OnDisable()
    {
        Collectible.onCollected -= AddItem;
    }
    public void AddItem()
    {
        itemCount++;
        Debug.Log("Item collected! Total items: " + itemCount);
    }
}
