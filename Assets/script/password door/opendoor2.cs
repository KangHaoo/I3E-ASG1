using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class opendoor2 : MonoBehaviour
{

    private Animator anim;

    private bool IsAtDoor = false;

    [SerializeField] private TextMeshProUGUI CodeText;
    string codeTextValue = "";
    public string safeCode;
    public GameObject CodePanel;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frameß
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

        if (Input.GetKey(KeyCode.E) && IsAtDoor == true)
        {
            CodePanel.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            IsAtDoor = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        IsAtDoor = false;
        CodePanel.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void AddDigit(string digit)
    {
        codeTextValue += digit;
    }




}
