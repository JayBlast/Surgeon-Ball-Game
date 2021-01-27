using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public Rigidbody cutter;
//public Vector2 textureCoord; //I configured these wrong and it might have thought of something better

public class ScarPainter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //cutter = GetComponent<Rigidbody>();//sets cutter to current gameplay value
        //Renderer rend = GetComponent<Renderer>();

        // duplicate the original texture and assign to the material
        /*Texture2D texture = Instantiate(rend.material.mainTexture) as Texture2D;
        rend.material.mainTexture = texture;*/
    }

    // Update is called once per frame
    void Update()
    {
        //This is pretty unnecessary
        /*if (!Input.GetMouseButton(0)) return; //default case to note check for udpate

        RaycastHit hit;
        if (!Physics.Raycast(cutter.ScreenPointToRay(Input.mousePosition), out hit))
            return;
        Renderer rend = hit.transform.GetComponent<Renderer>();
        MeshCollider meshCollider = hit.collider as MeshCollider;

        if (rend == null || rend.sharedMaterial == null || rend.sharedMaterial.mainTexture == null || meshCollider == null)
            return;
        Texture2D tex = rend.material.mainTexture as Texture2D;
        Vector2 pixelUV = hit.textureCoord;
        pixelUV.x *= tex.width;
        pixelUV.y *= tex.height;

        tex.SetPixel((int)pixelUV.x, (int)pixelUV.y, Color.black);
        tex.apply();
        }*/
    }
    void OnCollisionEnter(Collision col)//determines what happens when two objects touch
    {
        if(col.gameObject.name == "Platform")
        {
            //put draw statement here
            return;
        }
    }
    void OnCollisionExit(Collision col)//determines what happens when two objects stop touching
    {

    }
}
