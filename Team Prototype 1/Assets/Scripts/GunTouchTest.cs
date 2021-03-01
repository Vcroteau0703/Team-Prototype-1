using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTouchTest : MonoBehaviour
{

    private Touch touch;
    private Vector2 touchPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            //Instantiate()
        }
    }
}
