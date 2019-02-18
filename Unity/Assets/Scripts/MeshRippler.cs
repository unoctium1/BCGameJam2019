using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
 public class MeshRippler : MonoBehaviour
{
    
    Mesh mymesh;
    float speed = 8f;
    private float distance;
    [SerializeField]
    private Goal goal;
    float yFactor = 1f;
    Vector2 originPos = new Vector2(0, 0);

    // Start is called before the first frame update 
    void Start()
    {
        distance = goal.GetDistance();

        //float size = transform.localScale.x/2;
        
        //CreateRipples();
    }

    // Update is called once per frame
    void Update()
    {
        mymesh = GetComponent<MeshFilter>().mesh;
        if (mymesh != null)
        {
            distance = goal.GetDistance();
            var vertices = mymesh.vertices;

            for (var i = 0; i < vertices.Length; i++)
            {
                float offset = (vertices[i].x * vertices[i].x) + (vertices[i].z * vertices[i].z);
                var ripples1 = Mathf.Sin(Time.time * -speed + (offset + (vertices[i].x * distance) + (vertices[i].z * distance)) * 4) * yFactor;
                //  var ripples2 = Mathf.Sin(Time.time * -speed + (offset + (vertices[i].x * distanceX2) + (vertices[i].z * distanceZ2)) * 4) * .01f;
                vertices[i].y = ripples1;

                //2. Height should be a function of the relationship between vertex distance and furthest distance
                float vertexDistance = Vector2.Distance(new Vector2(vertices[i].x, vertices[i].z), originPos);
                vertices[i].y *= (distance - vertexDistance) / distance;
            }

            mymesh.vertices = vertices;
            mymesh.RecalculateNormals();
        }
    }
}

