using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aracinvebin : MonoBehaviour
{
    public bool calisiyor;
    public GameObject kamera,karakter,sp;
    araccontrol arac;
    // Start is called before the first frame update
    void Start()
    {
        arac = GetComponent<araccontrol>();
        arac.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && calisiyor)
        {
            calisiyor = false;
            calisiyor = false;
            arac.enabled = false;
            kamera.SetActive(false);
            karakter.SetActive(true);
            karakter.transform.position = sp.transform.position;
        }
    }
    void OnTriggerStay(Collider nesne)
    {
        if (nesne.gameObject.tag=="Player")
        {
            karakter = nesne.gameObject;
            if (Input.GetKeyDown(KeyCode.F)&& !calisiyor)
            {
                calisiyor = true;
                arac.enabled = true;
                kamera.SetActive(true);
                karakter.SetActive(false);
            }
        }
    }
}
