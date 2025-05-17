using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 5f;        // 자동차 이동 속도
    public float destroyPosition = -15f;  // 이 x좌표보다 왼쪽으로 가면 파괴

    void Update()
    {
        // 왼쪽으로 이동
        transform.Translate(Vector2.left * speed * Time.deltaTime);

        //transform.position += Vector2.left * speed * Time.deltaTime;

        // 지정된 위치보다 왼쪽으로 이동했는지 확인
        if (transform.position.x < destroyPosition)
        {
            // 게임 오브젝트 파괴
            Destroy(gameObject);
        }
    }
}
