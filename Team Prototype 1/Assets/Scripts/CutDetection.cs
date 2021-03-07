using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutDetection : MonoBehaviour
{

    CutterTest cutManager;

    // Start is called before the first frame update
    void Start()
    {
        cutManager = GameObject.Find("Cutter Manager").GetComponent<CutterTest>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col == cutManager.cutColliders[0])
        {
            Debug.Log("Make left true");
        }
    }
}
