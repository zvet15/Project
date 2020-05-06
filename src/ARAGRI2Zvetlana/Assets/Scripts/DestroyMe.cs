using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DestroyMe : MonoBehaviour
{
    //void OnTriggerEnter(Collider other)
    //{
    //    Destroy(other.gameObject);
    //}
    //private const float DOUBLE_CLICK_TIME = .2f;
    //private float lastClickTime; 
    //void Update()
    //{ 
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        //var currentObjectPosition = transform.position;
    //        //float timeSinceLastClick = Time.time - lastClickTime;
    //        //if (timeSinceLastClick <= DOUBLE_CLICK_TIME)
    //        //{
    //        //    Debug.Log("Double click");
    //        //    Destroy(currentObjectPosition);

    //        //}
    //        //lastClickTime = Time.time;
    //        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hit;

    //        if (Physics.Raycast(ray, out hit, 100))
    //        {
    //            //Choose one of them below!!!

    //            /// Name Comparison
    //            if (hit.collider.gameObject.name.equals("NameOfTheObject"))
    //            {
    //                ///Do Logic
    //                Console.Log(hit);
    //            }
    //        }
    //    }
    //}

    //GameObject go;
    //void Update()
    //{
    //    RaycastHit hit;


    //    if (Physics.Raycast(transform.position, -Vector3.forward, out hit)&& Input.GetMouseButtonDown(0))
    //    {
    //        print("Found an object - distance: " + hit.transform.gameObject);
    //        go = hit.transform.gameObject;
    //        Destroy(go);
    //    }
    //}
     
    public void BtnTest()
    {
        Debug.Log(EventSystem.current.currentSelectedGameObject.name);
    }
    

}

