using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sigensu:MonoBehaviour
{
    void Start()
    {
        var pos=new Vector3(2,1,5);
        var axis=new Vector3(0,1,0);
        var angle = 90.0f;
        var newPos = makeRotatePosition(pos, axis, angle);
        Debug.Log(newPos);
    }

    static Quaternion makeRotateQuaternion(Vector3 axis,float angle)
    {
        angle /= 2;
        var sin = Mathf.Sin(angle);
        var cos = Mathf.Cos(angle);
        axis = axis.normalized*sin;
        return new Quaternion(axis.x,axis.y,axis.z,cos);
    }

    static Quaternion posQuaternion(Vector3 pos)
    {
        return new Quaternion(pos.x,pos.y,pos.z,0);
    }

    Vector3 makeRotatePosition(Vector3 originPos,Vector3 axis,float angle)
    {
        var rotateQuaternion = makeRotateQuaternion(axis, angle);
        var pos = posQuaternion(originPos);
        var result=pos*rotateQuaternion;
        Debug.Log(result.w);
        return new Vector3(result.x,result.y,result.z);
    }
}
