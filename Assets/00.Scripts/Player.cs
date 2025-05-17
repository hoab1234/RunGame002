using UnityEngine;

public class Player : MonoBehaviour
{
    public Rigidbody2D rigid2D;
    public float jumpForce = 10f;
    private bool isGrounded = true;

    public Sprite jumpSprite;

    public Animator animator;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            // 점프 포스 값 , rigid에서 gravity값 , 조절해서 자연스러운 점프 만들기
            rigid2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;

            animator.SetBool("isJumping", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 바닥에 닿았을 때
        if (collision.gameObject.name.Equals("Ground"))
        {
            isGrounded = true;

            animator.SetBool("isJumping", false);
        }
    }
}