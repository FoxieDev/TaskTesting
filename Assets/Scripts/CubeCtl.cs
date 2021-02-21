using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCtl : MonoBehaviour
{
    Color m_MouseOverColor = Color.red;
    Color m_OriginalColor;
    MeshRenderer m_Renderer;
    bool mouseOver;
    GameManager gm;

    void Start()
    {
        gm = GameObject.Find("cam").GetComponent<GameManager>();
        m_Renderer = GetComponent<MeshRenderer>();
        m_OriginalColor = m_Renderer.material.color;
    }

    void OnMouseOver()
    {
        mouseOver = true;
        if(Input.GetMouseButtonDown(0)) {
            gm.addObj(this.gameObject);
            Debug.Log("clicked");
        }
    }

    void OnMouseExit()
    {
        mouseOver = false;
    }

    void Update() {
        if(mouseOver){
            m_Renderer.material.color = m_MouseOverColor;
        }
        else 
        {
            m_Renderer.material.color = m_OriginalColor;
        }
    }
}
