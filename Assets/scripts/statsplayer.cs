using UnityEngine;

public class statsplayer : MonoBehaviour
{
    public float hp;
    public float noDamagetime;
    private float tiempoUltimoDaņo;
    private GameManager gameManager;

    public void Start()
    {
        gameManager = FindObjectOfType<GameManager>();

    }

    public void Update()
    {
        if (Time.time < tiempoUltimoDaņo + noDamagetime )
        {
            return;

        }
    }
    public void DaņoRecibir(float daņo) 
    {
        hp -= daņo;
        if (hp <= 0)
        {
            Morir();

        }

        tiempoUltimoDaņo = Time.time;
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

            DaņoRecibir(enemyDamage);
        }
    }
}
