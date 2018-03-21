using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DoorAOpen : MonoBehaviour
{
    public Text doorOpenText;

    // Use this for initialization
    void Start()
    {
        doorOpenText.text = "The door is closed";
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void setGameKeyCount()
    {
        //-----
        
    }

    void OnTriggerEnter(Collider other)
    {
        
        doorOpenText.color = Color.green;
        doorOpenText.text = "The door is open";
        GetComponent<Animator>().SetTrigger("DoorATrigger");
    }
}