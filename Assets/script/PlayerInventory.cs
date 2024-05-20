using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInventory : MonoBehaviour
{
    //To show how many crystals the player have in the ui
    public int NumberOfCrystals { get; private set; }

    public UnityEvent<PlayerInventory> OnCrystalCollected;

    public void CrystalCollected()
    {
        NumberOfCrystals++;
        OnCrystalCollected.Invoke(this);
    }
}


