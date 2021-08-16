using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpperBound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("SIIIIIIIIIIIIIIIIIIIIIIIII:" + col.gameObject.name);

    //    if (!(col.gameObject.name.Equals("Ship")))
      //  {
            Destroy(col.gameObject);
         //   Destroy(gameObject);
       // }
        
        Debug.Log("colision con :" + col.gameObject);

        //   if (!(col.gameObject.name.Equals("Ship")))
        //  {
        //   Destroy(col.gameObject);
        // Destroy(gameObject);
        // }
      //  Destroy(gameObject);
    }
}