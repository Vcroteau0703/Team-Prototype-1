using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunTouchTest : MonoBehaviour
{

    private Vector3 touch;
    private Vector2 touchPosition;
    AudioSource audioSource;
    public GameObject bulletHole;
    float width;
    float height;
    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < Input.touchCount; i++)
        {
            if(Input.GetTouch(i).phase == TouchPhase.Began)
            {
                touch = Input.GetTouch(i).position;
                audioSource.Play();
                touch.z = Camera.main.nearClipPlane;
                position = Camera.main.ScreenToWorldPoint (touch);

                Instantiate(bulletHole, position, Quaternion.identity);
                Debug.Log(position);
            }
        }
    }
}
