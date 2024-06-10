using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
public class InterdimensionalTransport : MonoBehaviour
{

    public Material[] materials;

    void Start()
    {
        foreach(var mat in materials)
        {
            mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
        }
    }


    void OnTriggerStay(Collider other)
    {
        if(other.name != "Camera")
        {
            return;
        }
        if(transform.position.z > other.transform.position.z)
        {
            Debug.Log("Di dalam portal");
            foreach(var mat in materials)
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.Equal);
            }
        }
        else
        {
            Debug.Log("Di luar portal");
            foreach(var mat in materials)
            {
                mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
            }
        }

    }

    void OnDestroy()
    {
        foreach(var mat in materials)
        {
            mat.SetInt("_StencilTest", (int)CompareFunction.NotEqual);
        }
    }
    void Update()
    {  
    }
}