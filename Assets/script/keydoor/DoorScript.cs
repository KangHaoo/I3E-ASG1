using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public GameObject hand;
    public GameObject keyistrue;
    public bool isplayer;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        isplayer = false;
        animator = GetComponent<Animator>();
    }
    //show hand icon when player is close to the door
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
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
    // Update is called once per frame
    // So if player get key, then open door and hides hands. Animation show also during this time
    void Update()
    {
        if (keyistrue.active)
        {
            if (isplayer)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    hand.SetActive(false);
                    animator.enabled = true;

                }
                


            }
        }
    }
}
