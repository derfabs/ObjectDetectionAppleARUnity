using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MQTT_Sender : MonoBehaviour
{
    public string topic;
    public string message;
    public string tagOfTheMQTTReceiver = "MQTTReceiver";
    public MQTT_Receiver MQTT_Receiver;


    // Start is called before the first frame update
    void Start()
    {
        MQTT_Receiver = GameObject.FindGameObjectsWithTag(tagOfTheMQTTReceiver)[0].gameObject.GetComponent<MQTT_Receiver>();
        SendMessage();
    }

    public void SendMessage()
    {
        MQTT_Receiver.topicPublish = topic;
        MQTT_Receiver.messagePublish = message;
        MQTT_Receiver.Publish();
    }
    
   
}
