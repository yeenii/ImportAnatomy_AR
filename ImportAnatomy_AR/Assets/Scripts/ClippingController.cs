using Dummiesman;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class ClippingController : MonoBehaviour
{
    ObjFromFile off;

    public GameObject currentGameObject;
    public Transform tf;
    public Toggle m_Toggle;
    public Material mat;

    void Start()
    {
        //Skin,Muscle,Bone Clipping UI -Toggle

        off = GameObject.Find("GameManager").GetComponent<ObjFromFile>(); //ObjFromFile.cs


        //m_Toggle.GetComponent<Toggle>().isOn = false;
        
         currentGameObject = gameObject;


        tf = GameObject.Find("Clipping_UI").transform.Find(off.ModelName + "Toggle"); //모델이름+Toggle 찾기 
        m_Toggle = tf.GetComponent<Toggle>(); //Fetch the Toggle GameObject



        //Add listener for when the state of the Toggle changes, to take action
        if (m_Toggle.GetComponent<Toggle>().isOn = true)
        {
            m_Toggle.onValueChanged.AddListener(delegate
            {
                ToggleValueChanged(m_Toggle);
            });
        }
 

            

   
        
    }

    //Output the new state of the Toggle into Text
    void ToggleValueChanged(Toggle change)
    {

        mat=Resources.Load<Material>("Materials/Mask");
        mat.renderQueue = 3017;
        //currentGameObject.SetActive(m_Toggle.isOn);
    }

}
