using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private TextMeshProUGUI CrystalText;

    // Start is called before the first frame update
    void Start()
    {
        CrystalText = GetComponent<TextMeshProUGUI>();
    }

    public void UpdateCrystal(PlayerInventory playerInventory)
    {
        CrystalText.text = playerInventory.NumberOfCrystals.ToString();
    }
}
