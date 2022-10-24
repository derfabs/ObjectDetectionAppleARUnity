using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastAction : MonoBehaviour
{
    public MQTT_Sender MQTT_Sender;
    public OSC_Sender osc_Sender;
    
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnRaycastHit()
    {
        
        MQTT_Sender.SendMessage();
        osc_Sender.SwitchVideoToTwo();
    }
}
