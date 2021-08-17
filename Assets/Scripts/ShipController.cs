using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Experimental.TerrainAPI;

[RequireComponent(typeof(Rigidbody2D))]
public class ShipController : MonoBehaviour
{
    private new Rigidbody2D rigidbody;
    private Vector2 movement;
    public AudioSource shootingSound; 
    public GameObject bullet;
   // public GameObject BulletPositionReference;

    public float speed = 5f;
    public Vector3 bulletOffset = new Vector3(0, 0.5f, 0);
    float shipBoundaryRadius = 0.5f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(x, y).normalized;

        Move(direction);
  //      float moveHorizontal = Input.GetAxis("Horizontal");
    //    movement = new Vector2(moveHorizontal * speed * Time.deltaTime, 0f);
        //transform.position.
      //  transform.position= vement;

        if (Input.GetKeyDown(KeyCode.Space))
       {

            
            //Acá lo importante es aprender la función Instatiate(). En este caso
            // el primer parámetro el Prefab que queremos instanciar, el segundo
            // parámetro es la posición donde lo vamos instanciar (en este caso la posición de la nave)
            // y el tercero es la rotación del Prefab que se está instanciando.
            Instantiate(bullet, transform.position + bulletOffset, transform.rotation);
            shootingSound.Play();
        }
    }

    void Move(Vector2 direction)
    {

        Vector2 pos = transform.position;
    
		// First to vertical, because it's simpler
		if(pos.y+shipBoundaryRadius > Camera.main.orthographicSize) {
			pos.y = Camera.main.orthographicSize - shipBoundaryRadius;
		}
		if(pos.y-shipBoundaryRadius < -Camera.main.orthographicSize) {
			pos.y = -Camera.main.orthographicSize + shipBoundaryRadius;
		}

		// Now calculate the orthographic width based on the screen ratio
		float screenRatio = (float)Screen.width / (float)Screen.height;
		float widthOrtho = Camera.main.orthographicSize * screenRatio;

		// Now do horizontal bounds
		if(pos.x+shipBoundaryRadius > widthOrtho) {
			pos.x = widthOrtho - shipBoundaryRadius;
		}
		if(pos.x-shipBoundaryRadius < -widthOrtho) {
			pos.x = -widthOrtho + shipBoundaryRadius;
		}

		// Finally, update our position!!
		transform.position = pos;
    
    
    
    
        pos += direction * speed * Time.deltaTime;
        transform.position = pos;

    }

    void FixedUpdate()
    {
      
    }
}