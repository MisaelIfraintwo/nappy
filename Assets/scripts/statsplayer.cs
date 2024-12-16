using UnityEngine;

public class statsplayer : MonoBehaviour
{
    public float hp;
    public float noDamagetime;
    private float tiempoUltimoDaño;
    private GameManager gameManager;

    public void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

    }

    public void Update()
    {
        if (Time.time < tiempoUltimoDaño + noDamagetime )
        {
            return;

        }
    }
    public void DañoRecibir(float daño) 
    {
        hp -= daño;
        if (hp <= 0)
        {
            Morir();

        }

        tiempoUltimoDaño = Time.time;
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

            DañoRecibir(enemyDamage);
        }
    }
}
