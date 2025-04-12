using System.Collections;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

public class PlataformaEnMovimiento : MonoBehaviour
{
    public float speed = 0.5f;
    private float waitTime;
    public Transform[] moveSpots;
    public float startWaitTime = 2;
    private int i = 0;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWaitTime;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpots[i].transform.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, moveSpots[i].transform.position) < 0.1f)
        {
            if (waitTime <= 0)
            {
                if (moveSpots[i] = moveSpots[moveSpots.Length - 1])
                {
                    i++;
                }
                else
                {
                    i = 0;
                }

                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(transform);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.collider.transform.SetParent(null);
    }

}


//using System.Collections;
//using System.Collections.Generic;
//using System.Net;
//using UnityEngine;

//public class PlataformaEnMovimiento : MonoBehaviour
//{
//    public GameObject ObjetoAmover;
//public Transform StartPoint;
//public Transform EndPoint;

//public float Speed;

//private Vector3 MoverHacia;

//// Start is called before the first frame update
//void Start()
//{
//    MoverHacia = EndPoint.position;
//}

//// Update is called once per frame
//void Update()
//{
//    ObjetoAmover.transform.position = Vector3.MoveTowards(ObjetoAmover.transform.position, MoverHacia, Speed * Time.deltaTime);

//    if (ObjetoAmover.transform.position == EndPoint.position)
//    {
//        MoverHacia = StartPoint.position;
//    }

//    if (ObjetoAmover.transform.position == StartPoint.position)
//    {
//        MoverHacia = EndPoint.position;
//    }
//}
//}
