using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateGO : MonoBehaviour
{
    //protected Rigidbody rb;
    [SerializeField] protected float speedRotate = 0.1f;
    [SerializeField] protected int upSpeedPoint = 2;
    [SerializeField] protected TypeRotate typeRorate = TypeRotate.None;

    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        switch (typeRorate)
        {
            case TypeRotate.x:
                transform.Rotate(Vector3.right * speedRotate * Time.deltaTime);
                break;

            case TypeRotate.z:
                transform.Rotate(Vector3.forward * speedRotate * Time.deltaTime);
                break;
        }

        
    }

    public void SetSpeedRotate(int x)
    {
        speedRotate *= x;

        ChangeSpeed();

    }

    public void ChangeSpeed()
    {
        if (speedRotate > 0)
        {
            speedRotate += upSpeedPoint;
        }
        else speedRotate -= upSpeedPoint;
    }
}

public enum TypeRotate
{
    None = 0,
    x = 1,
    y = 2,
    z = 3,

}