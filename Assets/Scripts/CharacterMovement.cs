using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private float Horizontal;
    private float Vertical;
    private Rigidbody2D Rigidbody2D;
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");//Detectamos si pulsa A o D y movemos el personaje a la izquierda si pulsas A o a la derecha si pulsas D
        Vertical = Input.GetAxisRaw("Vertical");//Detectamos si pulsa W o S y movemos el personaje a arriba si pulsas W o a abajo si pulsas S
    }

    private void FixedUpdate()
    {

        Vector2 movement = new Vector2(Horizontal, Vertical) * moveSpeed * Time.deltaTime;
        Rigidbody2D.MovePosition(Rigidbody2D.position + movement);
    }
}
