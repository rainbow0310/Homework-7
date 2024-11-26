using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //stands for text mesh pro

[ExecuteAlways]

public class CoordinateLabels : MonoBehaviour
{
        TextMeshPro label;
        Vector2Int coordinates = new Vector2Int();
    // Start is called before the first frame update
    void Start()
    {
      label = GetComponent<TextMeshPro>(); 
      DisplayCoordinates(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(!Application.isPlaying){
             DisplayCoordinates();
             UpdateObjectName();
        }
    }

    void DisplayCoordinates(){
        coordinates.x = Mathf.RoundToInt(transform.parent.position.x/UnityEditor.EditorSnapSettings.move.x);
        coordinates.y = Mathf.RoundToInt(transform.parent.position.z/UnityEditor.EditorSnapSettings.move.z);

        label.text = coordinates.x + ", " + coordinates.y;
    }

    void UpdateObjectName(){
        transform.parent.name = coordinates.ToString();
    }
}
