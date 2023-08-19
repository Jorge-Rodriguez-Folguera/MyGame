using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoormsScript : MonoBehaviour
{
    private Animator Animator;
    private bool open;
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        open = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))//Si pulsa W y está en el suelo el personaje salta
        {
            if(open)
            {
                Physics2D.IgnoreCollision(GetComponent<Collider2D>(), obstacle.GetComponent<Collider2D>(), false);
                open = false;
                Animator.SetBool("Open", open);//Ejecutamos la animación de carrera
            }
            else
            {
                Physics2D.IgnoreCollision(GetComponent<Collider2D>(), obstacle.GetComponent<Collider2D>(), true);
                open = true;
                Animator.SetBool("Open", open);//Ejecutamos la animación de carrera
            }
        }
    }
}
