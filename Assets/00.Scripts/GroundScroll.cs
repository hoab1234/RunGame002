using UnityEngine;

public class GroundScroll : MonoBehaviour
{
    public float scrollSpeed = 0.5f;
    public  Renderer rend;

    void Update()
    {
        //방법 )
        // Offset 값을 시간에 따라 계속 변경하기
        float offset = Time.time * scrollSpeed;
        rend.material.mainTextureOffset = new Vector2(offset, 0);

        //방법 )
        rend.material.mainTextureOffset += new Vector2(scrollSpeed * Time.deltaTime, 0);
        // X축으로만 스크롤 (왼쪽에서 오른쪽으로)
        // offset 값이 1을 넘어도 Repeat 모드 덕분에 자연스럽게 반복됩니다
    }
}
