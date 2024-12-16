using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class enemystats : MonoBehaviour
{
    public float life;

    public Image vidita;

    public float vidaTotal;

    public GameObject particle;
    public void Start()
    {
        vidaTotal = life;
    }
    public void Dañotake(float daño) {
        GameObject effect = Instantiate (particle,transform.position,Quaternion.identity);
        Destroy(effect, effect.GetComponent<ParticleSystem>().main.duration);
        life -= daño;
        UpdateBarraVida();
        if (life <= 0 )
        {
            Morir();
        }
    
    }

    public void UpdateBarraVida() 
    {
        vidita.fillAmount = life / vidaTotal;
        
    }
    private void Morir() 
    {
        Destroy(gameObject);
    }
}
