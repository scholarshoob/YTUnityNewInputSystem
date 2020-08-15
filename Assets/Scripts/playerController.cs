using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(playerMovement))]
[RequireComponent(typeof(ConfigurableJoint))]
public class playerController : MonoBehaviour
{
    public InputManager controls;
    private playerMovement motor;
    private ConfigurableJoint joint;

    Vector2 moveInput;
    Vector2 lookInput;

    float speed = 5f;
    float lookSpeed = 0.1f;

    bool spacePressed;
    private float jetpackForce = 1000f;
    Vector3 _jetpackForce = Vector3.zero;

    [Header("Joint Config:")]
    [SerializeField]
    private JointProjectionMode jointMode = JointProjectionMode.PositionAndRotation;
    [SerializeField]
    private float jointSpring = 20f;
    [SerializeField]
    private float jointMaxForce = 40f;

    private void Awake()
    {
        motor = GetComponent<playerMovement>();
        controls = new InputManager();
        joint = GetComponent<ConfigurableJoint>();
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveInput = controls.MK.Movement.ReadValue<Vector2>();
        motor.move(getFinalVel(moveInput.x, moveInput.y));

        lookInput = controls.MK.Mouse.ReadValue<Vector2>();
        Vector3 yRot = new Vector3(0f, lookInput.x, 0f) * lookSpeed;
        motor.rotate(yRot);

        float xCamRot = lookInput.y * lookSpeed;
        motor.rotateCam(xCamRot);

        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            spacePressed = true;
        }
        if (Keyboard.current.spaceKey.wasReleasedThisFrame)
        {
            spacePressed = false;
        }
        if (spacePressed)
        {
            _jetpackForce = Vector3.up * jetpackForce;
            setJointSettings(0f);
        }
        else
        {
            setJointSettings(jointSpring);
        }
        motor.moveJetpack(_jetpackForce);

    }

    Vector3 getFinalVel(float axisX, float axisZ)
    {
        Vector3 moveHoriz = transform.right * axisX;
        Vector3 moveSide = transform.forward * axisZ;
        Vector3 finalVel = (moveHoriz + moveSide) * speed;
        return finalVel;
    }

    private void setJointSettings(float _jointSpring)
    {
        joint.projectionMode = jointMode;
        joint.yDrive = new JointDrive
        {
            positionSpring = _jointSpring,
            maximumForce = jointMaxForce
        };
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }
}
