using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicDraggable : MonoBehaviour
{
    Rigidbody2D rigidBody;

    Vector3 lastPosition;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void OnMouseDrag()
    {
        if (rigidBody != null)
        {
            rigidBody.MovePosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
        }
    }
}
