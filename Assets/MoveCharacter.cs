using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour
{
    public float moveDuration = 3.0f; // 움직이는 시간 (초)
    public float pauseDuration = 1.0f; // 멈추는 시간 (초)
    public float moveSpeed = 1.0f; // 움직임 속도
    public Vector3 moveRange = new Vector3(5.0f, 0, 5.0f); // 움직임 범위 (x, y)

    private Vector3 GetRandomDirection()
    {
        float randomX = Random.Range(-moveRange.x, moveRange.x);
        float randomZ = Random.Range(-moveRange.z, moveRange.z);
        return new Vector3(randomX, 0, randomZ).normalized; // 랜덤 방향
    }

    private IEnumerator MoveAndPauseRoutine()
    {
        while (true)
        {
            Vector3 direction = GetRandomDirection();

            // 움직이는 시간 동안 이동
            float moveEndTime = Time.time + moveDuration;
            while (Time.time < moveEndTime)
            {
                transform.position += direction * moveSpeed * Time.deltaTime;
                transform.forward = direction;
                yield return null;
            }

            // 멈추는 시간 동안 대기
            yield return new WaitForSeconds(pauseDuration);
        }
    }

    void Start()
    {
        StartCoroutine(MoveAndPauseRoutine());
    }
}
