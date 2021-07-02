using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class joystick : MonoBehaviour
{
    [SerializeField]
    public float speed;         //velocidade de movimento, regula no Unity
    private Vector3 direction; //direção que o player vai andar
    public Transform player;

    void Start()
    {

        direction = Vector3.up;
    }
    void Update()
    {
        
        MOVE();      //executa o movimento de acordo com o IF

    }
    public void MOVE()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
    public void W()
    {
        direction += Vector3.up;
    }
    public void A()
    {
        direction += Vector3.left;
    }
    public void S()
    {
        direction += Vector3.down;
    }
    public void D()
    {

        direction += Vector3.right;
    }
}
