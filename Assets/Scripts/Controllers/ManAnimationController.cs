
using UnityEngine;


public class ManAnimationController : MonoBehaviour
{
    private Animator animator; // or can be passed as [SerializeField]

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void StartRunning(Vector2 deltaPos)
    {
        animator.SetBool("Run", true);
    }

    public void Idle()
    {
        animator.SetBool("Run", false);
    }

    public void SetRunSpeed(float speed)
    {
        animator.SetFloat("RunSpeed", speed);
    }

}
