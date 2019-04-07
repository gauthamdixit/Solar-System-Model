using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugRadius : MonoBehaviour
{
    public Mesh mesh;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown("f"))
        {
         
            
            Mesh mesh = GameObject.Find("Sun").GetComponent<MeshFilter>().mesh;
            Vector3[] vertices = mesh.vertices;
            float radius = Vector3.Distance(GameObject.Find("Sun").transform.position, vertices[0]);
            Debug.Log(GameObject.Find("Sun").transform.position);
            Debug.Log(vertices[0].ToString());
                Debug.Log("Radius of Sun: " + radius);
            
        }
    }
}
