using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenDoor : MonoBehaviour
{

    private Animator anim;

    private bool IsAtDoor = false;

    [SerializeField]private TextMeshProUGUI CodeText;
    string codeTextValue = "";
    public string safeCode;
    public GameObject CodePanel;

    //get animation
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // all this code is to check wther if the door is open, if the door is open code panel is false
    //codetext value refer to the amount of number you can type on the keypad
    //check the player is near the door and press E to get the codepanel
    void Update()
    {
        CodeText.text = codeTextValue;

        if (codeTextValue == safeCode)
        {
            anim.SetTrigger("OpenDoor");
            CodePanel.SetActive(false);
        }

        if (codeTextValue.Length >= 4)
        {
            codeTextValue = "";
        }

        if(Input.GetKey(KeyCode.E) && IsAtDoor == true)
        {
            CodePanel.SetActive(true);
        }
    }
    //plaayer enter the area to see cursor and code panel
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            IsAtDoor = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
    // player enter the area to see cursor and code panel

    private void OnTriggerExit(Collider other)
    {
        IsAtDoor = false;
        CodePanel.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    //allow player to type up to 4 length in the code text value
    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }




}
