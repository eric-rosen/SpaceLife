using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMerge : MonoBehaviour
{
    public float threshold_magnitude = 2f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (threshold_magnitude < collision.relativeVelocity.magnitude)
        {
            Debug.Log("Attached!");

            FixedJoint2D fj = this.gameObject.AddComponent<FixedJoint2D>();
            fj.connectedBody=collision.rigidbody;

        }
        else
        {
            Debug.Log("Not hard enough...");
        }
    }
}
