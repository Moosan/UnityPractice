using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sigensu:MonoBehaviour
{
    public Vector3 Axis;
    public float RotateSpeed;
    protected void Update()
    {
        transform.rotation=Quaternion.Euler(new Vector3(0,10*RotateSpeed*Time.time,0));
        transform.position = makeRotatePosition(transform.position, Axis, RotateSpeed*Time.deltaTime);
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

    static Quaternion ConjugateQuaternion(Quaternion originQuaternion)
    {
        var q = originQuaternion;
        return new Quaternion(-q.x,-q.y,-q.z,q.w);
    }

    static Vector3 makeRotatePosition(Vector3 originPos,Vector3 axis,float angle)
    {
        var rotateQuaternion = makeRotateQuaternion(axis, angle);
        var pos = posQuaternion(originPos);
        var conjugate = ConjugateQuaternion(rotateQuaternion);
        var result=rotateQuaternion*pos*conjugate;
        return new Vector3(result.x,result.y,result.z);
    }
}
