using UnityEngine;

public class GroundScroll : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    public  Renderer rend;

    void Update()
    {
        //��� )
        // Offset ���� �ð��� ���� ��� �����ϱ�
        float offset = Time.time * scrollSpeed;
        rend.material.mainTextureOffset = new Vector2(offset, 0);

        //��� )
        rend.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0);
        // X�����θ� ��ũ�� (���ʿ��� ����������)
        // offset ���� 1�� �Ѿ Repeat ��� ���п� �ڿ������� �ݺ��˴ϴ�
    }
}
