using UnityEngine;

public class Indicator : MonoBehaviour
{
    public GameObject indicator;
    public Transform target;

    Renderer rd;

    void Start()
    {
        rd = GetComponent<Renderer>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (target == null)
        {
            // avoid errors
        }
        else if (rd.isVisible == false)
        {
            if (indicator.activeSelf == false)
            {
                indicator.SetActive(true);
                Vector2 dir = target.position - transform.position;
                RaycastHit2D ray = Physics2D.Raycast(transform.position, dir);

                if (ray.collider != null)
                {
                    indicator.transform.position = ray.point;
                }
            }       
        } else
        {
            if (indicator.activeSelf == true)
            {
                indicator.SetActive(false);
            }
        }
    }
}
