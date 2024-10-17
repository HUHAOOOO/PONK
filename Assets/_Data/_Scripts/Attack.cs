using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] private GameObject attackPosition;
    [SerializeField] private float attackRadius;
    [SerializeField] private LayerMask BallLayer;

    public virtual void TriggerAttack()
    {

        Collider2D[] detectedObjects = Physics2D.OverlapCircleAll(attackPosition.transform.position, attackRadius, BallLayer);

        foreach (Collider2D collider in detectedObjects)
        {
            collider.transform.parent.parent.GetComponent<RotateGO>().SetSpeedRotate(-1);
        }

    }

    public virtual void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(attackPosition.transform.position, attackRadius);
    }




}
