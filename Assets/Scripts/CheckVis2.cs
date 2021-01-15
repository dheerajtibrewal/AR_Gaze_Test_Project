using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVis2 : MonoBehaviour
{
    public Transform target;
    public Camera catchingCamera;
    public GameObject Annotate1;

   
    
    
   // Camera cam;

    void Start()
    {
       // cam = GetComponent<Camera>();

         if (catchingCamera == null){
        catchingCamera = GameObject.FindGameObjectWithTag("CatchingCamera").GetComponent<Camera>() as Camera;
    }

    
    }

     IEnumerator ExampleCoroutine(){
           yield return new WaitForSeconds(2f);
           Annotate1.SetActive(true);
           

     }

    void Update()
    {
        Vector3 viewPos = catchingCamera.WorldToViewportPoint(target.position);
        if (viewPos.x > 0.2F && viewPos.x < 0.6F)
            {
                StartCoroutine(ExampleCoroutine());
            }
        else{
                StopCoroutine(ExampleCoroutine());
                Annotate1.SetActive(false);
          
        }
            
    }
}
