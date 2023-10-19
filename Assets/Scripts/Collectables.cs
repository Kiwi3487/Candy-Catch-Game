using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collectables : MonoBehaviour
{
    public static Collectables instance;
    [SerializeField] private int point;
    private static int totalPoint;
    public Text scoreText;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        scoreText.text = point.ToString() + " POINTS";
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Destroy(gameObject);
            totalPoint += point;
            Debug.Log("Total points" + totalPoint);
            scoreText.text = scoreText.ToString() + "Points";
        }

        if (collision.transform.tag == "Ground")
        {
            Destroy(gameObject);
        }
    }
}
