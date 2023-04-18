using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Checkpoint : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _scoreText;
    private int _score = 0;
    // Start is called before the first frame update
    void Start()
    {
        _score = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _score++;
            _scoreText.text = "Score: " + _score;
            Debug.Log("Score: " + _score);
        }
    }
}
