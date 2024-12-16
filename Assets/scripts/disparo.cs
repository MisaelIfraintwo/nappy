using UnityEngine;

public class disparo : MonoBehaviour
{
    public GameObject bala;
    public Transform shoot;
    public float fuerzaShoot;
    public float tiemPershoot;
    private float tiempoultDisp;
   
    public void Update()
    {
        if (Input.GetButtonDown("Fire1") && puedeshootear())
        {
            shootear(); 
            }
    }
    bool puedeshootear()
    {
        return Time.time >= tiempoultDisp + tiemPershoot;
    }

    private void shootear()
    {
        

        Vector3 direccionshoot = Camera.main.transform.forward;

        GameObject Bala = Instantiate(bala, shoot.position, Quaternion.LookRotation(direccionshoot));

        Rigidbody rb = Bala.GetComponent<Rigidbody>();

        rb.AddForce(direccionshoot* fuerzaShoot, ForceMode.Impulse);

        tiempoultDisp = Time.time;
    }
}
