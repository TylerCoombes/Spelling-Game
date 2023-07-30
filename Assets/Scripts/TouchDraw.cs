using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TouchDraw : MonoBehaviour
{
    GameObject newGameObject;
    public List<GameObject> lineList = new List<GameObject>();
    LineRenderer line;
    Coroutine drawing;

    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButtonDown(0))
        {
            StartLine();
        }

        if(Input.GetMouseButtonUp(0))
        {
            FinishLine();
        }

        if(Input.GetMouseButtonDown(1))
        {
            RemoveLine();
        }
    }

    void StartLine()
    {
        if(drawing != null)
        {
            StopCoroutine(drawing);
        }
        drawing = StartCoroutine(DrawLine());
    }

    void FinishLine()
    {
        StopCoroutine(drawing);
    }

    IEnumerator DrawLine()
    {
        newGameObject = Instantiate(Resources.Load("Line") as GameObject, new Vector3 (0,0,0), Quaternion.identity);
        lineList.Add(newGameObject);
        line = newGameObject.GetComponent<LineRenderer>();
        line.positionCount = 0;

        while(true)
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            position.z = 0;
            line.positionCount++;
            line.SetPosition(line.positionCount-1, position);
            yield return null;
        }
    }

    void RemoveLine()
    {
        Destroy(lineList[lineList.Count-1].gameObject);
        lineList.RemoveAt(lineList.Count-1);
    }
}
