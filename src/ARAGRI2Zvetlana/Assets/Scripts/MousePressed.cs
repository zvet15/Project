using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePressed : MonoBehaviour
{
    private const float DOUBLE_CLICK_TIME = 0.2f;
    private float lastClickTime;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            float timeSinceLastClick = Time.time - lastClickTime;
            Debug.Log("Time since last clicked" + timeSinceLastClick);
            Debug.Log("Last click time" + lastClickTime);
            if (timeSinceLastClick <= DOUBLE_CLICK_TIME)
            {


                //METHOD1

                // mypos = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10f);
                //do actions e.g.    Instantiate(myobject, mypos, Quaternion.identity);


                //METHOD2

                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit; //xobject laqat //irrid jahbat ma collider
                if (Physics.Raycast(ray, out hit))   //allows upto 5 objects to be created
                {
                    Debug.Log("Ray cast" + hit.transform);
                    GameData mydata = (GameData)FindObjectOfType(typeof(GameData));
                    mydata.myLabels.Remove(hit.transform.gameObject);
                    Destroy(hit.transform.gameObject);
                    //.RemoveAll(gameObject => gameObject == null);
                    //count++;
                }

            }
            lastClickTime = Time.time;
        }
    }
}