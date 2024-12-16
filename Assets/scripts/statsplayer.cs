using UnityEngine;

public class statsplayer : MonoBehaviour
{
    public float hp;
    public float noDamagetime;
    private float tiempoUltimoDa�o;
    private GameManager gameManager;

    public void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

    }

    public void Update()
    {
        if (Time.time < tiempoUltimoDa�o + noDamagetime )
        {
            return;

        }
    }
    public void Da�oRecibir(float da�o) 
    {
        hp -= da�o;
        if (hp <= 0)
        {
            Morir();

        }

        tiempoUltimoDa�o = Time.time;
    }
    private void Morir() 
    {
        gameManager.UnlockCursor();
        gameManager.SceneChange(0);
        Destroy(gameObject);
           
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            float enemyDamage = 1f;

            Da�oRecibir(enemyDamage);
        }
    }
}
