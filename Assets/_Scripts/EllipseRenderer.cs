using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class EllipseRenderer : MonoBehaviour 
{
    private LineRenderer lineRenderer;

    [Range(3, 36)]
    public int segments;
    public Ellipse ellipse;

    private void Awake()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    private void Start()
    {
        CalculateAndDisplayEllipse();
    }

    void CalculateAndDisplayEllipse()
    {
        Vector3[] points = new Vector3[segments + 1];
        for (int i = 0; i < segments; i++)
        {
            Vector2 pos = ellipse.Evaluate(((float)i / (float)segments));
            points[i] = new Vector3(pos.x, pos.y, 0);
        }

        Debug.Log("segments = "+segments);
        points[segments] = points[0];

        lineRenderer.positionCount = segments;
        lineRenderer.SetPositions(points);
    }

    private void OnValidate()
    {
        if(lineRenderer != null)
        {
            CalculateAndDisplayEllipse();
        }
    }
}
