using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemies : MonoBehaviour
{
    public Transform target;
    //private Vector2 dis;
    public float enemieswalksspeed;
    private Transform gronddetec;

    Rigidbody2D rb;
    int jumpforge;
    Animator an;
    bool facingleft;





    bool isopgrond;
    public Transform grondok;
    public float okradius;
    public LayerMask grondwatis;



    // Start is called before the first frame update
    void Start()
    {
      //  target = gameObject.GetComponent<player>().transform;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        rb = GetComponent<Rigidbody2D>();
        jumpforge = 6;
        an = this.gameObject.GetComponent<Animator>();



        enemieswalksspeed = 0.5f;

    }

    // Update is called once per frame
    void Update()
    {
        if(target.transform.position.x > this.gameObject.transform.position.x && facingleft == false)
        {
            flipcharacter();
        }
        if (target.transform.position.x < this.gameObject.transform.position.x && facingleft == true)
        {
            flipcharacter();
        }

        float dis = Vector2.Distance(transform.position, target.position);

        Vector2 newpos = new Vector2(transform.position.x, target.transform.position.y);

        isopgrond = Physics2D.OverlapCircle(grondok.position, okradius, grondwatis);

        if (dis > 1.1 && isopgrond && dis < 10)
        {
            //walks
            transform.position = Vector2.Lerp(transform.position, target.position, enemieswalksspeed *Time.deltaTime);
            an.SetBool("walks", true);

            //

        }
        else
        {
            an.SetBool("walks", false);
        }
        if(dis < 1.5)
        {
            an.SetBool("attacks", true);
            //stop
        }
        else
        {
            an.SetBool("attacks", false);
        }
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.gameObject.CompareTag("grond"))
        {
            Debug.Log("hit a wall");

            rb.velocity = Vector2.up * jumpforge;
        }
    }
    void flipcharacter()
    {
        facingleft = !facingleft;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;

    }
}
