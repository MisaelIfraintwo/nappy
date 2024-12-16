using UnityEngine;

public class playercontroller : MonoBehaviour
{
    public float velocidad;
    public float sensibilidadM;
    private Rigidbody rb;
    private Transform camara;
    private float rotationX;
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
        camara = Camera.main.transform;
        Cursor.lockState= CursorLockMode.Locked;
        Cursor.visible= false;
    }
      void Update()
    {
        float mousex = Input.GetAxis("Mouse X") * sensibilidadM;
        float mousey = Input.GetAxis("Mouse Y") * sensibilidadM;
        rotationX -= mousey;
        rotationX = Mathf.Clamp(rotationX, -90f, 90f);
        camara.localRotation = Quaternion.Euler(rotationX, 0f, 0f);
        transform.Rotate(Vector3.up * mousex);

    }
    private void FixedUpdate()
    {
        float movX = Input.GetAxis("Horizontal");
        float movY = Input.GetAxis("Vertical");

        Vector3 movimiento = transform.right * movX + transform.forward * movY;
        rb.MovePosition(rb.position + movimiento * velocidad * Time.deltaTime);
         
    }
}
