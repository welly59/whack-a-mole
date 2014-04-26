using UnityEngine;
using System.Collections;

public class MoleController : MonoBehaviour {

    public Vector2 position;
    public float xpos;



	// Use this for initialization
	void Start () {


        xpos = transform.position.x;

			StartCoroutine(Move()) ;

	
	}
	
	// Update is called once per frame
	void Update () {
        CheckPosition();
	
	}

	IEnumerator Move()
	{
        float wait = Random.Range(1f, 4f);
        print(wait);
        yield return new WaitForSeconds(wait);
        Vector2 position = transform.position;
        float yposition = transform.position.y;
        if (transform.position.y < -2.75)
        {

            rigidbody2D.velocity = new Vector2(0, 2);
            //CheckPosition();
           
        }
        //else
        //{
        //    rigidbody2D.velocity = new Vector2(0, -1);
        //}

    }

    void CheckPosition()
    {
        if (transform.position.y > -2.75)
        {
            rigidbody2D.velocity = new Vector2(0, -2);

        }
        if (transform.position.y < -3.75)
        {

            rigidbody2D.velocity = new Vector2(0, 0);
            transform.position = new Vector2(xpos, -3.74f);
            StartCoroutine(Move());
        }
    }
}
