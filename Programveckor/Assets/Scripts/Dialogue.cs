using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class Dialogue : MonoBehaviour
{
    bool isPlayerNearby = false;
    public GameObject dialogueText;
    TextMeshProUGUI textComponent;
    public GameObject Panel;
    public string line1;
    public string line2;
    public string line3;
    public string line4;

    int lineNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        textComponent = dialogueText.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerNearby == true && Input.GetKeyDown(KeyCode.E))
        {
            
            dialogueText.SetActive(true);
            Panel.SetActive(true);

            if (lineNumber == 1)
            {
                textComponent.text = line1;
            }

            if (lineNumber == 2)
            {
                textComponent.text = line2;
            }

            if (lineNumber == 3)
            {
                textComponent.text = line3;
            }

            if (lineNumber == 4)
            {
                textComponent.text = line4;
            }

            lineNumber += 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        isPlayerNearby = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isPlayerNearby = false;
        dialogueText.SetActive(false);
        Panel.SetActive(false);
        lineNumber = 1;
    }
}