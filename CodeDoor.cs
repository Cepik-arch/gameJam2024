using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CodeDoor : MonoBehaviour
{
    public GameObject codingDevice;
    private string code = "";
    public TextMeshProUGUI codeText;
    public float textTime = 2f;

    void Update()
    {
        if (code != "")
        {
            textTime -= Time.deltaTime;
            if (textTime <= 0)
            {
                code = "";
                codeText.text = code;
                textTime = 2f;
            }
        }
        if (code == "1994")
        {
            Debug.Log("Kod je spravny");
            codingDevice.SetActive(false);
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        codingDevice.SetActive(true); 
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        codingDevice.SetActive(false);
    }

    public void WriteNumber(string number)
    {
        textTime = 2f;
        code += number;
        codeText.text = code;
    }

    public void DeleteNumebers()
    {
        code = "";
        codeText.text = code;
    }
}
