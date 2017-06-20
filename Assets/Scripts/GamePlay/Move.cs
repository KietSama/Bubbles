using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed = 1f;
    public float speed_2 = 1f;

    private float tempY;

    private Vector3 tempPos;

    private void Start()
    {
        tempY = transform.position.y;

        tempPos = transform.position;

        DrawLine(transform.position, transform.position + new Vector3(0, 100f, 0), Color.red);
    }

    private void Update()
    {
        tempPos.y = tempY + speed_2 * Mathf.Sin(speed * Time.time);

        transform.position = tempPos;
    }

    void DrawLine(Vector3 start, Vector3 end, Color color, float duration = 0.2f)
    {
        GameObject myLine = new GameObject();
        myLine.transform.position = start;
        myLine.AddComponent<LineRenderer>();
        LineRenderer lr = myLine.GetComponent<LineRenderer>();
        lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
        lr.SetColors(color, color);
        lr.SetWidth(0.1f, 0.1f);
        lr.SetPosition(0, start);
        lr.SetPosition(1, end);
        //GameObject.Destroy(myLine, duration);
    }
}