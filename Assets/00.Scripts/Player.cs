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
            // ���� ���� �� , rigid���� gravity�� , �����ؼ� �ڿ������� ���� �����
            rigid2D.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            isGrounded = false;

            animator.SetBool("isJumping", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // �ٴڿ� ����� ��
        if (collision.gameObject.name.Equals("Ground"))
        {
            isGrounded = true;

            animator.SetBool("isJumping", false);
        }
    }
}