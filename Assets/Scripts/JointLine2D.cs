using UnityEditor.SceneManagement;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class JointLine2D : MonoBehaviour
{
    LineRenderer lineRenderer;

    Joint2D joint;

    // Start is called before the first frame update
    void Start()
    {
        joint = GetComponent<Joint2D>();
        lineRenderer = GetComponent<LineRenderer>();
        SetEdges();
    }

    // Update is called once per frame
    void Update()
    {
        SetEdges();
    }

    void SetEdges()
    {
        if (!joint)
        {
            Destroy(this);
            Destroy(lineRenderer);
        }
        else
        {
            Vector3[] positions = { joint.transform.position, joint.connectedBody.transform.position };
            lineRenderer.SetPositions(positions);
        }
    }
}
