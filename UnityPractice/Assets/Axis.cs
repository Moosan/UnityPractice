using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis : MonoBehaviour
{
    public GameObject AxisObject;
    private static GameObject _parent;
    private bool _end;

    void Start()
    {
        _end = false;
        if (_parent == null)
        {
            _parent=GameObject.Find("Axises");
        }
    }

    void Update()
    {
        if (AxisObject != null && transform.rotation.eulerAngles.y < 90 && !_end)
        {
            var obj = Instantiate(AxisObject, transform.position, new Quaternion());
            obj.transform.parent = _parent.transform;
        }
        else
        {
            _end = true;
        }
        
    }
}
