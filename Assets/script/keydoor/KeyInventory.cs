using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInventory : MonoBehaviour
{
    public GameObject inventoryimage;
    bool istrue;
    
    void Start()
    {
        istrue = false;

    }
    //to check inventory if there is key
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            istrue = true;
        }
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            istrue = false;
        }
        if (istrue)
        {
            inventoryimage.SetActive(true);
        }
        else
        {
            inventoryimage.SetActive(false);

        }
    }
}


