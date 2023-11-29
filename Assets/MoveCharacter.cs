using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour
{
    public float moveDuration = 3.0f; // �����̴� �ð� (��)
    public float pauseDuration = 1.0f; // ���ߴ� �ð� (��)
    public float moveSpeed = 1.0f; // ������ �ӵ�
    public Vector3 moveRange = new Vector3(5.0f, 0, 5.0f); // ������ ���� (x, y)

    private Vector3 GetRandomDirection()
    {
        float randomX = Random.Range(-moveRange.x, moveRange.x);
        float randomZ = Random.Range(-moveRange.z, moveRange.z);
        return new Vector3(randomX, 0, randomZ).normalized; // ���� ����
    }

    private IEnumerator MoveAndPauseRoutine()
    {
        while (true)
        {
            Vector3 direction = GetRandomDirection();

            // �����̴� �ð� ���� �̵�
            float moveEndTime = Time.time + moveDuration;
            while (Time.time < moveEndTime)
            {
                transform.position += direction * moveSpeed * Time.deltaTime;
                transform.forward = direction;
                yield return null;
            }

            // ���ߴ� �ð� ���� ���
            yield return new WaitForSeconds(pauseDuration);
        }
    }

    void Start()
    {
        StartCoroutine(MoveAndPauseRoutine());
    }
}
