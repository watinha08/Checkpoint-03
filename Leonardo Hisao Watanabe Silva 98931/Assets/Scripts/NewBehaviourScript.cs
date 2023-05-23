using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] private float velocity = 10;
    private int i = 0;

    private Transform playerTransform;

    void Start()
    {
        playerTransform = GetComponent<Transform>();
    }

    void Update()
    {
        Move();
    }

    void Move()
    {
        float moveX = Input.GetAxis("Horizontal") * velocity * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * velocity * Time.deltaTime;
        playerTransform.Translate(moveX, moveY, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Money")
        {
            i++;
            Destroy(collision.gameObject);
            print("Fui Coletada!");
            print("Foram coletadas " + i + " Moedas!");
        }
    }
}
