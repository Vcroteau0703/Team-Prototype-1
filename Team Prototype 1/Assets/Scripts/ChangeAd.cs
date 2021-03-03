using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeAd : MonoBehaviour
{
    Sprite petahAd;
    Sprite loisAd;
    public Transform bulletHoleHolder;
    Image ad;
    List<Sprite> ads;

    // Start is called before the first frame update
    void Start()
    {
        ad = GetComponent<Image>();

        ads = new List<Sprite>();

        // getting ad images
        petahAd = Resources.Load<Sprite>("PetahAd");
        loisAd = Resources.Load<Sprite>("LoisAd");

        // putting ad images into ads list
        ads.Add(petahAd);
        ads.Add(loisAd);

    }

    public void ChangeAdAndClean()
    {
        //cleaning up bullet holes
        foreach(Transform child in bulletHoleHolder)
        {
            GameObject.Destroy(child.gameObject);
        }
        // changing ad to random ad in list
        //int randomAd = Random.Range(0, ads.Count);

        ad.sprite = ads[1];
    }
}
