using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAd : MonoBehaviour
{
    Sprite petahAd;
    Sprite loisAd;
    Sprite jadenAd;
    public Transform bulletHoleHolder;
    Image ad;

    public Sprite[] ads;

    // Start is called before the first frame update
    void Start()
    {
        ad = GetComponent<Image>();

    }

    public void ChangeAdAndClean()
    {
        //cleaning up bullet holes
        foreach(Transform child in bulletHoleHolder)
        {
            GameObject.Destroy(child.gameObject);
        }
        // changing ad to random ad in list
        int randomAd = Random.Range(0, ads.Length);

        ad.sprite = ads[randomAd];
    }
}
