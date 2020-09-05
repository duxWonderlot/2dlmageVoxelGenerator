using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Runtime_Texture
{
    public class Gene : MonoBehaviour
    {

        // public float Offset;
        [SerializeField]
        Texture2D heightMap;
        [Range(0, 10)]
        public float height_Scale;
         //[SerializeField]
        //GameObject obj;
        [SerializeField]
        Color[] pixels;
        [SerializeField]
        Color color;
        int i, j;
        [SerializeField]
        List<GameObject> collect_objects = new List<GameObject>();
        int count = 0;
        [SerializeField]
        GameObject prefab;
        [SerializeField]
        Transform plane;
        private void Start()
        {

            pixels = heightMap.GetPixels(0, 0, heightMap.width, heightMap.height);

            for (i = 0; i < heightMap.width; i++)
            {
                for (j = 0; j < heightMap.height; j++)
                {
                    color = pixels[(i * heightMap.width) + j];
                    // = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    GameObject obj =Instantiate(prefab);
                    obj.transform.rotation = plane.transform.rotation;
                    obj.transform.position = new Vector3(i, color.grayscale * height_Scale, j);
                    obj.gameObject.transform.SetParent(this.gameObject.transform);
                    obj.GetComponent<Renderer>().material.color = color;
                    collect_objects.Add(obj);
                }
            }
        }

         
    }
}
