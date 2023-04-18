using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] private float _scrollSpeed = 0.5f;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void fixedUpdate()
    {

    }
    void Update()
    {
        Scroller();
    }
    private void Scroller()
    {
        //move towards the left
        transform.Translate(Vector2.left * _scrollSpeed * Time.deltaTime);

        if (transform.position.x < -7.0f)
        {
            transform.position = new Vector2(1.0f, transform.position.y);
        }

    }
}
