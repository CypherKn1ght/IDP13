using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayInventory : MonoBehaviour
{
    public InventoryObject inventory;
    public GameObject inventoryPrefab;
    public int X_START;
    public int Y_START;    
    public int X_SPACE_BETWEEN_ITEM;
    public int NUMBER_OF_COLUMN;
    public int Y_SPACE_BETWEEN_ITEM;
    Dictionary<GameObject, InventorySlot> itemsDisplayed = new Dictionary<GameObject,InventorySlot>();
    // Start is called before the first frame update
    void Start()
    {
        CreateSlots();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateSlots()
    {
        foreach (KeyValuePair<GameObject, InventorySlot> _slot in itemsDisplayed)
        {
            if (_slot.Value.item != null)
            {
               // _slot.Key.GetComponent<Image>().sprite = inventory.(_slot.Value.item.uiDisplay);
               // _slot.Key.GetComponent<Image>().color = new Color(1, 1, 1, 1);
            }
            else
            {
               // _slot.Key.GetComponent<Image>().color = new Color(1, 1, 1, 0);
            }
        }
    }
    public void CreateSlots()
    {
        itemsDisplayed = new Dictionary<GameObject, InventorySlot>();
        for (int i = 0; i < inventory.Container.Count; i++)
        {
            var obj = Instantiate(inventoryPrefab, Vector3.zero, Quaternion.identity, transform);
            obj.GetComponent<RectTransform>().localPosition = GetPosition(i);
            
            itemsDisplayed.Add(obj, inventory.Container[i]);
        }
    }
    public Vector3 GetPosition(int i)
    {
        return new Vector3(X_START + (X_SPACE_BETWEEN_ITEM * (i % NUMBER_OF_COLUMN)), Y_START + (-Y_SPACE_BETWEEN_ITEM * (i / NUMBER_OF_COLUMN)), 0f);
    }
}
