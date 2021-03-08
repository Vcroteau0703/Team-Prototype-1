using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CutterTest : MonoBehaviour
{
    Vector3 touchPosition; //Update to MainTouch Vector3 once working with Tori
    public GameObject cutObject;
    GameObject ad;
    public GameObject cutVersion; //The cut version of the ad

    public bool leftCut = false;
    public bool rightCut = false;
    public bool upCut = false;
    public bool bottomCut = false;

    [HideInInspector] public bool wasCut; //This will help set the Ad's Image Component back to "active" in it's own respective button script if this bool is true 
    bool cut = true;

    public GameObject[] cutColliders;

    Vector3 direction;
    public float moveSpeed;

    Touch touch;

    private void Start()
    {
        ObjectAssignment();
        wasCut = false;
    }

    private void Update()
    {
        CutDebugErrors();

        if(leftCut && rightCut)
        {
            wasCut = true;
            cutVersion = Resources.Load<GameObject>("Prefab Cut Versions/Jaden/Cut Jaden Horz");
            Instantiate(cutVersion, cutObject.transform);

            /*
            if(ad.GetComponent<Image>().sprite == Resources.Load("transparentjaden"))
            {
                cutVersion = Resources.Load<GameObject>("Prefab Cut Versions/Jaden/Cut Jaden Horz");
                Instantiate(cutVersion, cutObject.transform);
            }
            */
        } 
        else if(upCut && bottomCut)
        {
            wasCut = true;

            if (ad.GetComponent<Image>().sprite == Resources.Load("transparentjaden"))
            {
                cutVersion = Resources.Load<GameObject>("Prefab Cut Versions/Jaden/Cut Jaden Vert");
                Instantiate(cutVersion, ad.transform);
            }
        }

        switch (wasCut)
        {
            case true:
                ad.GetComponent<Image>().enabled = false;
                break;

            case false:
                ad.GetComponent<Image>().enabled = true;
                break;
        }
        
    }



    void CutDebugErrors()
    {
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

    void ObjectAssignment()
    {
        ad = GameObject.Find("Ad");
        cutObject = GameObject.Find("Cutter");
        cutColliders = new GameObject[4];
        cutColliders[0] = GameObject.Find("Left Cut Collider");
        cutColliders[1] = GameObject.Find("Right Cut Collider");
        cutColliders[2] = GameObject.Find("Top Cut Collider");
        cutColliders[3] = GameObject.Find("Bottom Cut Collider");
    }
}
