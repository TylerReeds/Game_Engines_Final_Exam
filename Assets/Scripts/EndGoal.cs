using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGoal : Subject
{
    public float CurrentPoints
    {
        get { return Points; }
    }
    [SerializeField] private int Points = 0;

    private UIManager uiManager;

    void Awake()
    {
        uiManager = gameObject.AddComponent<UIManager>();
    }

    void OnEnable()
    {
        if (uiManager)
            Attach(uiManager);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Tile")
        {
            collision.gameObject.SetActive(false);
            Points += 1000;
            NotifyObservers();
        }
    }
}

