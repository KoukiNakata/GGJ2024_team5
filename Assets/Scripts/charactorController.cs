using UnityEngine;
/// <summary>
/// キャラクター
/// </summary>
public class charactorController : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject player;
    [SerializeField] Rigidbody rigidbodyPlayer;
    [SerializeField] float speed;
    [SerializeField] float Xsensityvity, Ysensityvity;
    [SerializeField] float minX, maxX;
    [SerializeField] private bool cursorLock;
    private float x, z;

    private Quaternion cameraRot, characotrRot;
    
    void Start()
    {
        cameraRot = mainCamera.transform.localRotation;
        characotrRot = player.transform.localRotation;
    }

    void Update()
    {
        charactorMove();
        viewControler();
        cursorLocker();
    }

    /// <summary>
    /// キャラクター移動
    /// </summary>
    private void charactorMove()
    {
        x = Input.GetAxisRaw("Horizontal") * speed;
        z = Input.GetAxisRaw("Vertical") * speed;

        player.transform.position += new Vector3(mainCamera.transform.forward.x, 0, mainCamera.transform.forward.z) * z + mainCamera.transform.right * x;
    }

    /// <summary>
    /// カメラ操作
    /// </summary>
    private void viewControler()
    {
        //マウス操作によるカメラ
        float xRot = Input.GetAxis("Mouse X") * Ysensityvity;
        float yRot = Input.GetAxis("Mouse Y") * Xsensityvity;

        cameraRot *= Quaternion.Euler(-yRot, 0, 0);
        characotrRot *= Quaternion.Euler(0, xRot, 0);

        cameraRot = ClampRotation(cameraRot);

        //characotrRot = ClampRotation(characotrRot);
        mainCamera.transform.localRotation = cameraRot;
        player.transform.localRotation = characotrRot;
    }

    public Quaternion ClampRotation(Quaternion q)
    {
        //q = x,y,z,w (x,y,zはベクトル（量と向き）：wはスカラー（座標とは無関係の量）)

        q.x /= q.w;
        q.y /= q.w;
        q.z /= q.w;
        q.w = 1f;

        float angleX = Mathf.Atan(q.x) * Mathf.Rad2Deg * 2f;

        angleX = Mathf.Clamp(angleX, minX, maxX);

        q.x = Mathf.Tan(angleX * Mathf.Deg2Rad * 0.5f);

        return q;
    }

    private void cursorLocker()
    {
        if (cursorLock)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        else if (!cursorLock)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}