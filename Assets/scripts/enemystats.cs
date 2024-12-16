using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class enemystats : MonoBehaviour
{
    public float life;

    public Image vidita;

    public float vidaTotal;

    public void Start()
    {
        vidaTotal = life;
    }
    public void Dañotake(float daño) {

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
