using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class playerMovement : MonoBehaviour
{
    private Vector3 finalVel = Vector3.zero;
    private Vector3 rotation = Vector3.zero;

    private float camRotationX = 0f;
    private float currentCamRotationX;
    private float camRotLimit = 100f;

    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private Camera cam;

    private Vector3 jetpackForce = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        performMovement();
        performRotation();
    }

    public void move(Vector3 velocity)
    {
        finalVel = velocity;
    }

    public void rotate(Vector3 rotateVector)
    {
        rotation = rotateVector;
    }

    public void rotateCam(float camRotVector)
    {
        camRotationX = camRotVector;
    }

    public void moveJetpack(Vector3 _jetpackForce)
    {
        jetpackForce = _jetpackForce;
    }

    void performMovement()
    {
        if(finalVel != Vector3.zero)
        {
            rb.MovePosition(rb.position + finalVel * Time.fixedDeltaTime);
        }
        if(jetpackForce != Vector3.zero)
        {
            rb.AddForce(jetpackForce * Time.fixedDeltaTime, ForceMode.Acceleration);
        }
    }

    void performRotation()
    {
        rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation));
        currentCamRotationX -= camRotationX;
        currentCamRotationX = Mathf.Clamp(currentCamRotationX, -camRotLimit, camRotLimit);
        cam.transform.localEulerAngles = new Vector3(currentCamRotationX, 0f, 0f);
    }
}
