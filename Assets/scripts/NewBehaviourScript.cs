using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    public Renderer renderObject;
   
    void Update()
    {

        renderObject.material.mainTextureOffset += new Vector2(0f, speed * Time.deltaTime);
    }
}
