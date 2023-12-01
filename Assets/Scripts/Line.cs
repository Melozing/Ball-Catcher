using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float moveSpeed;
    float xDirection;

    GameController m_gc;

    // Start is called before the first frame update
    void Start()
    {
        m_gc = FindAnyObjectByType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");

        if(m_gc.IsGameover())
        {
            return;
        }

        float moveStep = moveSpeed * xDirection *Time.deltaTime;

        if((transform.position.x <= -8f && xDirection <0) || (transform.position.x >= 8f && xDirection >0))
        {
            return;
        }

        transform.position = transform.position + new Vector3(moveStep, 0, 0);
    }
}
