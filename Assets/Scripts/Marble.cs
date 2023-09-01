using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marble : MonoBehaviour
{
    private TrailRenderer trail;

    // Start is called before the first frame update
    void Start()
    {
        trail = GetComponent<TrailRenderer>();
        trail.widthMultiplier = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
