using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;        // �ڵ��� �̵� �ӵ�
    public float destroyPosition = -15f;  // �� x��ǥ���� �������� ���� �ı�

    void Update()
    {
        // �������� �̵�
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        //transform.position += Vector2.left * speed * Time.deltaTime;

        // ������ ��ġ���� �������� �̵��ߴ��� Ȯ��
        if (transform.position.x < destroyPosition)
        {
            // ���� ������Ʈ �ı�
            Destroy(gameObject);
        }
    }
}
