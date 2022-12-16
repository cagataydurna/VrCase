using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitManager : MonoBehaviour
{   
    public static UnitManager _instance;
    public Transform player;
    public int unitCount;
    public GameObject unitType1,unitType2;
    void Start()
    {
        if(_instance==null)_instance=this;
        CreateUnit();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreateUnit(){
        if(unitCount<20){
            for(int i=0;i<20-unitCount;i++){
                
                
                GameObject clone=Instantiate(unitType1,new Vector3(Random.insideUnitCircle.normalized.x*20+player.transform.position.x,-0.54f,Random.insideUnitCircle.normalized.y*20+player.transform.position.z),Quaternion.identity);
                clone.transform.SetParent(this.gameObject.transform);
            }
            unitCount=20;
        }
    }
}
