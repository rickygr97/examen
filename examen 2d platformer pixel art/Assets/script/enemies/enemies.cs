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
   protected Animator an;
  protected  bool facingleft;

    protected float startdis;
    protected float enddis;
    protected float attackdis;







    bool isopgrond;
    public Transform grondok;
    public float okradius;
    public LayerMask grondwatis;



    // Start is called before the first frame update
   public virtual void Start()
    {
      //  target = gameObject.GetComponent<player>().transform;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

        rb = GetComponent<Rigidbody2D>();
        jumpforge = 7;
        an = this.gameObject.GetComponent<Animator>();



        enemieswalksspeed = 0.5f;

    }

    // Update is called once per frame
   public virtual void Update()
    {
        //if(target.transform.position.x > this.gameObject.transform.position.x && facingleft == false)
        //{
        //    flipcharacter();
        //}
        //if (target.transform.position.x < this.gameObject.transform.position.x && facingleft == true)
        //{
        //    flipcharacter();
        //}

        float dis = Vector2.Distance(transform.position, target.position);

        Vector2 newpos = new Vector2(transform.position.x, target.transform.position.y);

        isopgrond = Physics2D.OverlapCircle(grondok.position, okradius, grondwatis);

        if (dis > startdis && isopgrond && dis < enddis)
        {
            //walks
            transform.position = Vector2.Lerp(transform.position, target.position, enemieswalksspeed *Time.deltaTime);
            animationwalks();

            //

        }
        else
        {
            animationwalks2();

        }
        if(dis < attackdis)
        {
            animationattack();

            //stop
        }
        else
        {
            animationattack2();

        }
    }
   public virtual void OnCollisionEnter2D(Collision2D col)
    {
        if (col.collider.gameObject.CompareTag("grond"))
        {
            Debug.Log("hit a wall");

            rb.velocity = Vector2.up * jumpforge;
        }
    }
   public virtual void flipcharacter()
    {
        facingleft = !facingleft;
        Vector3 scaler = transform.localScale;
        scaler.x *= -1;
        transform.localScale = scaler;

    }
    public virtual void animationwalks()
    {
    }
    public virtual void animationwalks2()
    {
    }
    public virtual void animationattack()
    {
    }
    public virtual void animationattack2()
    {
    }
}
