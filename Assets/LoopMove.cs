using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopMove : MonoBehaviour
{
    [SerializeField]
    AnimationCurve curve;

    [SerializeField]
    Vector3 destination;

    Vector3 startPosition;
    float delta = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    private void FixedUpdate()
    {
        Debug.Log(curve.Evaluate(Time.fixedDeltaTime));
        //transform.position = Vector3.Lerp(startPosition, startPosition + destination, curve.Evaluate(Time.deltaTime));

        delta += Time.fixedDeltaTime;
        if (delta > 1.0f)
        {
            delta = 1.0f;
        }

        transform.position = Vector3.Lerp(startPosition, startPosition + destination, delta);

        if (delta >= 1.0f)
        {
            delta = 0.0f;
        }
    }
}
