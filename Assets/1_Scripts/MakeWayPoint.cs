using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeWayPoint : MonoBehaviour
{
    public Transform wayParent;
    public GameObject wayPointObj;

    private float way1 = -125f, way2 = -60f, x = 0f, y = 0.2f, z = 30f;
    private float way3 = -75.5f, way4 = -52f;

    private void Awake()
    {
        for (x = way1; x <= way2; x += 2f)
        {
            Instantiate(wayPointObj, new Vector3(x, y, z), Quaternion.identity, wayParent);
        }

        for (x = way2; z >= way3; z -= 2f)
        {
            Instantiate(wayPointObj, new Vector3(x, y, z), Quaternion.identity, wayParent);
        }

        for (z = way3; x <= way4; x += 2f)
        {
            Instantiate(wayPointObj, new Vector3(x, y, z), Quaternion.identity, wayParent);
        }
    }

}
