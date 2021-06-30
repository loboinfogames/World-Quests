using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    public GameObject OtherGameObject;
    void Start()
    {
        
    }
    //BATER NO INIMIGO E ELE MORRER
    void OnCollisionEnter2D(Collision2D Collision)
    {
        if (Collision.gameObject.tag == "Player")
        {
            Destroy(OtherGameObject);
        }
    }
}
