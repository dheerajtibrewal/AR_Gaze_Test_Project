using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckVisibility : MonoBehaviour
{
    public Transform target;
    public Camera catchingCamera;
    public GameObject Annotate1;
    public GameObject Annotate2;
    public GameObject Annotate3;
    public GameObject Annotate4;
    public GameObject Annotate5;

   
    
    
   // Camera cam;

    void Start()
    {
       // cam = GetComponent<Camera>();

         if (catchingCamera == null){
        catchingCamera = GameObject.FindGameObjectWithTag("CatchingCamera").GetComponent<Camera>() as Camera;
    }

    
    }

     IEnumerator ExampleCoroutine(){
           yield return new WaitForSeconds(1f);
           Annotate1.SetActive(true);
           Annotate2.SetActive(true);
           Annotate3.SetActive(true);
           Annotate4.SetActive(true);
           Annotate5.SetActive(true);

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
           Annotate2.SetActive(false);
           Annotate3.SetActive(false);
           Annotate4.SetActive(false);
           Annotate5.SetActive(false);
                
        }
            
    }
}
