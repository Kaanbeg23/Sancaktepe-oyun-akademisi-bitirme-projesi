using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gorev : MonoBehaviour
{
    public GameObject kazand�n;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name=="hedefaraba")
        {
            kazand�n.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            kazand�n.SetActive(false);
        }
    }
}
