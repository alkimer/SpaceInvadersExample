using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int initialHealth;
    private LifeBar _lifeBar;

 
    // Start is called before the first frame update
    void Start()
    
    {
        _lifeBar = new LifeBar(initialHealth);

    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("ENEMY:" + col.gameObject.name);
        Debug.Log("HEALTH:" + _lifeBar.Health);

        // Destruyo ls BAlA
        Destroy(col.gameObject);

        _lifeBar.DecreaseHealth(30);
        //si se terminó la energía me destruyo
        if (_lifeBar.Health == 0) { Destroy(gameObject); }

    }
}