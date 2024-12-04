using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIManager : Observer
{
    private EndGoal goal;
    private float _currentPoints;

    public static UIManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void OnGUI()
    {
        GUILayout.BeginArea(new Rect(50, 150, 200, 400));

        // Display score
        GUILayout.BeginHorizontal("box");
        GUILayout.Label("Current Number of Points: " + _currentPoints);
        GUILayout.EndHorizontal();

        GUILayout.EndArea();
    }
    public override void Notify(Subject subject)
    {
        if (!goal)
           goal = subject.GetComponent<EndGoal>();
        if (goal)
        {

            _currentPoints = goal.CurrentPoints;

        }
    }
}

