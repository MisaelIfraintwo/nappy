using UnityEngine;

public class balad : MonoBehaviour
{
    public float duration;
    public float da�o;
    
    void Start()
    {
        Destroy(gameObject, duration);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Enemy")) 
        {
            enemystats enemi = other.GetComponent<enemystats>();

            enemi.Da�otake(da�o);
            
            Destroy(gameObject);


        }
    }


}
