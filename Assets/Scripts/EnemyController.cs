using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class EnemyController: MonoBehaviour
{
    private LifeBar _lifeBar = new LifeBar();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("ENEMY:" + col.gameObject.name);

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
