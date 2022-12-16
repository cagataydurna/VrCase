using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InCameraView : MonoBehaviour
{
    Camera camera;
    
    SkinnedMeshRenderer renderer;
    Plane[] cameraFrustum;
    Bounds bounds;
    void Start()
    {
        camera=Camera.main;
        renderer=GetComponent<SkinnedMeshRenderer>();
        bounds = GetComponent<BoxCollider>().bounds;
         
    }

    // Update is called once per frame
    void Update()
    {
        cameraFrustum=GeometryUtility.CalculateFrustumPlanes(camera);
        if(GeometryUtility.TestPlanesAABB(cameraFrustum,bounds)){
            transform.parent.forward=Camera.main.transform.position-this.gameObject.transform.position;


        }else{
            transform.parent.position=Vector3.Lerp(new Vector3(this.gameObject.transform.parent.position.x,-0.55f,this.gameObject.transform.parent.position.z),new Vector3(Camera.main.transform.position.x,-0.55f,Camera.main.transform.position.z),Time.deltaTime*0.1f);

        }
    }
}
