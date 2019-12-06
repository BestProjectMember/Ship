using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwingBaby : MonoBehaviour
{
    public float timeframe;
    public Transform start, end;
    private bool up = false;

    void Start()
    {

    }
    private void Update()
    {
        if (up)
        {
            transform.rotation = Quaternion.Lerp(start.rotation, end.rotation, Time.time * timeframe);
        }
        else
        {
            transform.rotation = Quaternion.Lerp(end.rotation, start.rotation, Time.time * timeframe);
        }
        if (transform.rotation == start.rotation)
        {
            up = true;
        } else if (transform.rotation == end.rotation)
        {
            up = false;
        }
    }

}
