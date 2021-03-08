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
            cutManager.leftCut = true;
        } 
        else if (col == cutManager.cutColliders[1])
        {
            Debug.Log("Make right true");
            cutManager.rightCut = true;
        }
        else if (col == cutManager.cutColliders[2])
        {
            Debug.Log("Make top true");
            cutManager.upCut = true;
        }
        else if (col == cutManager.cutColliders[3])
        {
            Debug.Log("Make bottom true");
            cutManager.bottomCut = true;
        }

    }
}
