using UnityEngine;

public class doorController : gimicBase, Igimic
{
    [SerializeField] Animator animator;
    [SerializeField] GameObject door;
    private string flagName = "openFlag";

    private void Start()
    {
        changeTag();
    }

    override public void getedGimic()
    {
        animator.SetBool(flagName, true);
        //SE
        Destroy(door.GetComponent<doorController>());
    }
}
