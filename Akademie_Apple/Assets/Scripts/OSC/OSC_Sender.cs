using UnityEngine;
using System.Collections;

public class OSC_Sender : MonoBehaviour
{

    public OSC osc;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("o"))
        { Test(); }
    }


    void Test()
    {
       
        OscMessage message;

        message = new OscMessage();
        message.address = "/composition/columns/1/connect";
        message.values.Add(1);
        //message.values.Add(2);
        //message.values.Add(3);
        osc.Send(message);
            Debug.Log("Osc message sent");
    }

    public void SwitchVideoToTwo()
    {
        OscMessage message;
        message = new OscMessage();
        message.address = "/composition/layers/clips/2/connect";
        message.values.Add(1);

    }
     
}