using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject startObj;
    public GameObject endObj;
    
    public GameManager()
    {

    }
    void Start(){
        startObj = null;
        endObj = null;
    }
    public void addObj(GameObject obj)
    {
        if(startObj == null){
            startObj = obj;
        } 
        else if(endObj == null) {
            endObj = obj;
            connect();
        }
        else {
            return;
        }
    }

    public void connect()
    {
        if(startObj == null || endObj == null){
            return;
        }
        LineRenderer lineRenderer = new GameObject("Line").AddComponent<LineRenderer>();
        lineRenderer.startColor = Color.black;
        lineRenderer.endColor = Color.black;
        lineRenderer.startWidth = 0.01f;
        lineRenderer.endWidth = 0.01f;
        lineRenderer.positionCount = 2;
        lineRenderer.useWorldSpace = true;    

//For drawing line in the world space, provide the x,y,z values
        lineRenderer.SetPosition(0, startObj.transform.position); //x,y and z position of the starting point of the line
        lineRenderer.SetPosition(1, endObj.transform.position); //x,y and z position of the starting point of the line
        startObj = null;
        endObj = null;
    }
}