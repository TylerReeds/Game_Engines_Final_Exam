using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tile_Behaviour : MonoBehaviour
{
    private Vector2 moveDirection;
    public float Speed = 1f;

    private void Update()
    {
        transform.Translate(moveDirection * Time.deltaTime * Speed);
    }

    public void SetMoveDirection(Vector2 dir)
    {
        moveDirection = dir;
    }

    private void Disable()
    {
        gameObject.SetActive(false);
    }
    private void OnDisable()
    {
        CancelInvoke();
    }
}
