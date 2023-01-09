using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastAction : MonoBehaviour
{
   // public MQTT_Sender MQTT_Sender;
    public OSC_Sender osc_Sender;
    public AudioSource AudioSource;
    
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
        if (AudioSource.clip != null)
        { AudioSource.Play(); }
        osc_Sender.Cat();
       // MQTT_Sender.SendMessage();
        
       

    }
}
