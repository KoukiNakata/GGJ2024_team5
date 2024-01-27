using UnityEngine;
/// <summary>
/// キャラクター
/// </summary>
public class charactorController : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject player;
    [SerializeField] Rigidbody rigidbodyPlayer;
    [SerializeField] float RayDistance;
    [SerializeField] float speed;
    [SerializeField] float upSpeed;
    [SerializeField] float Xsensityvity, Ysensityvity;
    [SerializeField] float minX, maxX;
    [SerializeField] private bool cursorLock;

    private float x, z;
    private Quaternion cameraRot, characotrRot;
    public bool activeFlag;

    void Start()
    {
        activeFlag = true;
        cameraRot = mainCamera.transform.localRotation;
        characotrRot = player.transform.localRotation;
    }

    void Update()
    {
        if (!activeFlag) return;
        charactorMove();
        viewControler();
        cursorLocker();
        lazer();
    }

    /// <summary>
    /// キャラクター移動
    /// </summary>
    private void charactorMove()
    {
        x = Input.GetAxisRaw("Horizontal") * speed;
        z = Input.GetAxisRaw("Vertical") * speed;

        player.transform.position += (new Vector3(mainCamera.transform.forward.x, 0, mainCamera.transform.forward.z) * z * speedUP() + mainCamera.transform.right * x);
    }

    private float speedUP()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            return upSpeed;
        }
        else
        {
            return 1.0f;
        }
    }

    /// <summary>
    /// カメラ操作
    /// </summary>
    private void viewControler()
    {
        float xRot = Input.GetAxis("Mouse X") * Ysensityvity;
        float yRot = Input.GetAxis("Mouse Y") * Xsensityvity;

        cameraRot *= Quaternion.Euler(-yRot, 0, 0);
        characotrRot *= Quaternion.Euler(0, xRot, 0);
        cameraRot = ClampRotation(cameraRot);

        mainCamera.transform.localRotation = cameraRot;
        player.transform.localRotation = characotrRot;
    }

    /// <summary>
    /// オブジェクト取得用レイ
    /// </summary>
    private void lazer()
    {
        Vector3 fwd = mainCamera.transform.TransformDirection(Vector3.forward);
        Ray ray = new Ray(transform.position, fwd);
        RaycastHit hit;

        //引数(       レイの開始地点、        レイの方向と長さ、レイの色、レイを表示する時間)
        Debug.DrawRay(mainCamera.transform.position, ray.direction * RayDistance, Color.red, 0.1f, false);

        //引数(ワールド座標でのレイの開始地点、レイの方向、レイが衝突を検知する最大距離、)
        if (Physics.Raycast(ray, out hit, RayDistance))
        {
            Debug.Log(hit.collider.gameObject.name);
        }
    }

    /// <summary>
    /// カーソルロック
    /// </summary>
    public void cursorLocker()
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

    /// <summary>
    /// 角度制御用関数
    /// </summary>
    /// <param name="q"></param>
    /// <returns></returns>
    private Quaternion ClampRotation(Quaternion q)
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
}