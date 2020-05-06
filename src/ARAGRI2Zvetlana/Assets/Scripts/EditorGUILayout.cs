using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EditorGUILayout : MonoBehaviour
{
    public GameObject myPrefab;
    public GameObject myPrefabSave;
    public Transform myParent;
    GameObject myLabel;



    public void CreateLabel()
    {
        Canvas canvas = FindObjectOfType<Canvas>();
        float h = canvas.GetComponent<RectTransform>().rect.height;
        float w = canvas.GetComponent<RectTransform>().rect.width;
        if (myLabel == null)
        {
            myLabel = Instantiate(myPrefab, transform.position, Quaternion.identity) as GameObject;
            GameObject saveButton = Instantiate(myPrefabSave, transform.position + new Vector3(0f, -30f, 0f), Quaternion.identity) as GameObject;
            myLabel.transform.SetParent(myParent);
            saveButton.transform.SetParent(myParent);
            myLabel.name = "myNewLabel";
        }
        
    }



}