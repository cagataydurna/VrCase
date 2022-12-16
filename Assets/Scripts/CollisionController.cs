using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag=="Player"){
            UnitManager._instance.unitCount--;
            UnitManager._instance.CreateUnit();

            Destroy(this.gameObject);
            
        }
    }
}
