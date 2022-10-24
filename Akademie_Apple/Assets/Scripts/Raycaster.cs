using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class Raycaster : MonoBehaviour
{

    public Camera playerCamera;
    public TMP_Text textDebug;
    
    public GameObject hitGameObject;
    public GameObject previousHitGameObject;


    void Awake()
    {

    }


    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
            textDebug.text = "TOUCHED";
            MakeRaycast();
        }

    }



    void MakeRaycast()
    {
        textDebug.text= "raycast";
        Vector3 ray = playerCamera.ScreenToWorldPoint(Input.GetTouch(0).position);
        Ray myRay = playerCamera.ScreenPointToRay(Input.GetTouch(0).position);
        RaycastHit hit;

        if (Physics.Raycast(myRay.origin, myRay.direction, out hit, 25))
        {
            hitGameObject = hit.collider.gameObject;
            textDebug.text = "object hit:" + hit.collider.gameObject.name;
        }
        if ((hitGameObject != previousHitGameObject && hitGameObject.GetComponent<RaycastAction>() != null) || (previousHitGameObject == null && hitGameObject.GetComponent<RaycastAction>() != null))
        {
            
            hitGameObject.GetComponent<RaycastAction>().OnRaycastHit();
            textDebug.text = "Raycast Action called";
        }

    }
}
