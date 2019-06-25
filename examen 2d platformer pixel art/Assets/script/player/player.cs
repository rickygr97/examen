using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    SpriteRenderer komkommer;
    int speed;
    Rigidbody2D rb;
    float moveinput;
    bool facingleft;

    bool isopgrond;
    public Transform grondok;
    public float okradius;
    public LayerMask grondwatis;

    public int jumpsjumpies;
    int jumpforce;

    int extrajump;





    // Start is called before the first frame update
    void Start()
    {
        komkommer = this.gameObject.GetComponent<SpriteRenderer>();
        speed = 5;
        rb = GetComponent<Rigidbody2D>();
        extrajump = 1;
        jumpforce = 5;



    }

    // Update is called once per frame
    void Update()
    {
        isopgrond = Physics2D.OverlapCircle(grondok.position, okradius, grondwatis);

        if(Input.GetKeyDown(KeyCode.W) && jumpsjumpies >0|| Input.GetKeyDown(KeyCode.UpArrow) && jumpsjumpies >0)
        {
            rb.velocity = Vector2.up * jumpforce;
            jumpsjumpies--;

        }
        else if (Input.GetKeyDown(KeyCode.W) && jumpsjumpies<=0 && isopgrond == true|| Input.GetKeyDown(KeyCode.UpArrow) && jumpsjumpies <= 0 && isopgrond == true)
        {
            rb.velocity = Vector2.up * jumpforce;
            

        }
        if (isopgrond == true)
        {
            jumpsjumpies = extrajump;

        }

        #region movement
        moveinput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveinput * speed, rb.velocity.y);
        #endregion
        #region characterleft
        if (facingleft == true && moveinput < 0)
        {
            flipcharacter();

        }
        if (facingleft == false && moveinput > 0)
        {
            flipcharacter();

        }
        #endregion
        #region firstwhatif

        //if (Input.GetKey(KeyCode.A))
        //{
        //    transform.position += Vector3.left * speed * Time.deltaTime;
        //    komkommer.flipX = false;

        //}
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.position += Vector3.right * speed * Time.deltaTime;
        //    komkommer.flipX = true;
        #endregion

        //}
    }
    void flipcharacter()
    {
        facingleft = !facingleft;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;

    }
}
