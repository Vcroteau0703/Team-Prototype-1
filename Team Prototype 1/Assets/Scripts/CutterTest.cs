using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutterTest : MonoBehaviour
{
    Vector3 touchPosition; //Update to MainTouch Vector3 once working with Tori
    public GameObject cutObject;
    GameObject ad;
    public GameObject cutVersion; //The cut version of the ad

    bool leftCut = false;
    bool rightCut = false;
    bool upCut = false;
    bool bottomCut = false;

    [HideInInspector] public bool wasCut; //This will help set the Ad's Image Component back to "active" in it's own respective button script if this bool is true 
    bool cut = true;

    public GameObject[] cutColliders;

    Vector3 direction;
    public float moveSpeed;

    private void Start()
    {
        cutObject = GameObject.Find("Cutter");
        cutColliders = new GameObject[4];
        cutColliders[0] = GameObject.Find("Left Cut Collider");
        cutColliders[1] = GameObject.Find("Right Cut Collider");
        cutColliders[2] = GameObject.Find("Top Cut Collider");
        cutColliders[3] = GameObject.Find("Bottom Cut Collider");  
    }

    private void Update()
    {
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            touchPosition = Camera.main.ScreenToWorldPoint(touchPosition);
            touchPosition.z = 0;
            direction = (touchPosition - cutObject.transform.position);
            
        }




        //Debug Error Stuff I just wanted to do in case a scene doesn't have the following objects
        if (!GameObject.Find("Left Cut Collider"))
        {
            Debug.LogError("Please add the Left Cut Collider prefab for this to work");
        }
        if (!GameObject.Find("Right Cut Collider"))
        {
            Debug.LogError("Please add the Right Cut Collider prefab for this to work");
        }
        if (!GameObject.Find("Top Cut Collider"))
        {
            Debug.LogError("Please add the Top Cut Collider prefab for this to work");
        }
        if (!GameObject.Find("Bottom Cut Collider"))
        {
            Debug.LogError("Please add the Bottom Cut Collider prefab for this to work");
        }
        if (!GameObject.Find("Cutter"))
        {
            Debug.LogError("Please add the Cutter prefab for this to work");
        }
    }
}
