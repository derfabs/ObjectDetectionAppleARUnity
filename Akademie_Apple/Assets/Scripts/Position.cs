using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Position : MonoBehaviour
{
    public TMP_Text Text;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Text.text = "X" + this.transform.position.x.ToString() + "Y" + this.transform.position.x.ToString() + "Z" + this.transform.position.z.ToString();

    }
}
