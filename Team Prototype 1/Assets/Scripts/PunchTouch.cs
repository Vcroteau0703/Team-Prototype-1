using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchTouch : MonoBehaviour
{

    bool punch;
    public GameObject shatteredGlass;
    public AudioClip shatterSFX;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0 && punch == false)
        {
            Touch touch = Input.GetTouch(0);
            shatteredGlass.SetActive(true);
            gameObject.GetComponent<AudioSource>().clip = shatterSFX;
            gameObject.GetComponent<AudioSource>().Play();
            punch = true;
        }
    }
}
