using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MQTT_Controller : MonoBehaviour

{
    public string nameController = "Controller 1";
    public string tagOfTheMQTTReceiver = "MQTTReceiver";
    public MQTT_Receiver _eventSender;
    

    void Start()
    {
        _eventSender = GameObject.FindGameObjectsWithTag(tagOfTheMQTTReceiver)[0].gameObject.GetComponent<MQTT_Receiver>();
        _eventSender.OnMessageArrived += OnMessageArrivedHandler;
    }

    private void OnMessageArrivedHandler(string newMsg)
    {
        this.GetComponent<TextMeshPro>().text = newMsg;
        Debug.Log("Event Fired. The message, from Object " + nameController + " is = " + newMsg);
    }

    
}
