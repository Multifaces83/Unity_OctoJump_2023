using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Hit : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            Destroy(collision.gameObject);
            _scoreText.text = "Game Over";
        }
    }
}
