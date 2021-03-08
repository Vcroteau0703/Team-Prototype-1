using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTouch : MonoBehaviour
{
    private Vector3 touch;
    private Vector2 touchPosition;
    AudioSource audioSource;
    public GameObject flame;
    public GameObject bulletHole;
    public GameObject explosion;
    public GameObject shatter;
    public Transform bulletHoleParent;
    Vector3 position;
    bool gun = false;
    bool explode = false;
    bool flamethrower = false;
    bool punch = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            if (Input.GetTouch(i).phase == TouchPhase.Began && gun)
            {
                touch = Input.GetTouch(i).position;
                audioSource.Play();
                touch.z = Camera.main.nearClipPlane;
                position = Camera.main.ScreenToWorldPoint(touch);

                Instantiate(bulletHole, position, Quaternion.identity, bulletHoleParent);
            }
            if (Input.GetTouch(i).phase == TouchPhase.Began && explode)
            {
                //explode the screen
                touch = Input.GetTouch(i).position;
                touch.z = Camera.main.nearClipPlane;
                position = Camera.main.ScreenToWorldPoint(touch);

                Instantiate(explosion, position, Quaternion.identity, bulletHoleParent);
            }
            if (Input.GetTouch(i).phase == TouchPhase.Began && flamethrower)
            {
                //Torch the scene
                touch = Input.GetTouch(i).position;
                touch.z = Camera.main.nearClipPlane;
                position = Camera.main.ScreenToWorldPoint(touch);

                Instantiate(flame, position, Quaternion.identity, bulletHoleParent);
            }
            if(Input.GetTouch(i).phase == TouchPhase.Began && punch)
            {
                //Punch the screen
                touch = Input.GetTouch(i).position;
                touch.z = Camera.main.nearClipPlane;
                position = Camera.main.ScreenToWorldPoint(touch);

                Instantiate(shatter, position, Quaternion.identity, bulletHoleParent);
            }
        }
    }

    public void ActivateGun()
    {
        explode = false;
        flamethrower = false;
        punch = false;
        gun = true;
    }

    public void ActivateNuke()
    {
        gun = false;
        flamethrower = false;
        punch = false;
        explode = true;
    }
    public void Activateflamethrower()
    {
        gun = false;
        punch = false;
        explode = false;
        flamethrower = true;
    }
    public void ActivatePunch()
    {
        gun = false;
        flamethrower = false;
        explode = false;
        punch = true;
    }
}
