using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;



public class SaveText : DefaultTrackableEventHandler
{
    InputField inputField; //texbox
    //getText form textbox 
    // string text= inputField.text.ToString();
    //public List<GameObject> myLabels = new List<GameObject>();
    public GameObject myTextmeshPrefab;
    private GameObject textBox;
    Transform myParent;



    protected override void Start()
    {
        myParent = GameObject.Find("ObjectTarget").transform;

    }



    public void AddLabel()
    {
        GameData mydata = (GameData)FindObjectOfType(typeof(GameData));
        textBox = GameObject.Find("Canvas/myNewLabel");
        inputField = textBox.GetComponent<InputField>();
        mydata.myLabels.Add((GameObject)Instantiate(myTextmeshPrefab, new Vector3(0f, 1f, 0.7f), Quaternion.identity));
        mydata.myLabels[mydata.myLabels.Count - 1].transform.SetParent(myParent);
        mydata.myLabels[mydata.myLabels.Count - 1].GetComponent<TextMesh>().text = inputField.text;//.GetComponent<Text>().text;




        Debug.Log(message: mydata.myLabels[mydata.myLabels.Count - 1].GetComponent<TextMesh>().text);
        Debug.Log(mydata.myLabels.Count);
        Destroy(textBox.gameObject);
        Destroy(GameObject.Find("Canvas/SaveButton(Clone)"));

    }

}