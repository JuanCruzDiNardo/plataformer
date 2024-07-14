using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller_Player_AntiBarrier : Controller_Player
{

    public override void OnCollisionEnter(Collision collision)
    {
        base.OnCollisionEnter(collision);

        if (collision.gameObject.CompareTag("Barrier"))
        {
            Physics.IgnoreCollision(collision.collider, this.GetComponent<Collider>(), true);
        }
        
    }


}
