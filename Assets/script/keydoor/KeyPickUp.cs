using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour
{
    public GameObject keyimage;
    public GameObject keyistrue;
    public GameObject hand;
    public bool isplayer;


    void Start()
    {
        isplayer = false;

    }

    //if shows player have picked up the key
    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            isplayer = true;
            hand.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            isplayer = false;
            hand.SetActive(false);
        }
    }

    //To shows image is in the inventory once it is pick up
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            keyimage.SetActive(true);
            keyistrue.SetActive(true);
            hand.SetActive(false);
            Destroy(gameObject);
        }
    }
}
