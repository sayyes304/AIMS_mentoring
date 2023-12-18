using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour
{
    public float moveDuration = 3.0f; // �����̴� �ð� (��)
    public float pauseDuration = 5.0f; // ���ߴ� �ð� (��)
    public float moveSpeed = 1.0f; // ������ �ӵ�
    public Vector3 moveRange = new Vector3(5.0f, 0, 5.0f); // ������ ���� (x, y)

    Animator animator;
    [SerializeField] bool isSelected;
    public GameObject Canvas;
    /*
    private Vector3 GetRandomDirection()
    {
        float randomX = Random.Range(-moveRange.x, moveRange.x);
        float randomZ = Random.Range(-moveRange.z, moveRange.z);
        return new Vector3(randomX, 0, randomZ).normalized; // ���� ����
    }

    private IEnumerator MoveAndPauseRoutine()
    {
        while (!isSelected)
        {
            Vector3 direction = GetRandomDirection();
            animator.SetBool("isMoving", true);

            // �����̴� �ð� ���� �̵�
            float moveEndTime = Time.time + moveDuration;
            while (Time.time < moveEndTime)
            {
                transform.position += direction * moveSpeed * Time.deltaTime;
                transform.forward = direction;
                yield return null;
            }
            animator.SetBool("isMoving", false);

            // ���ߴ� �ð� ���� ���
            yield return new WaitForSeconds(pauseDuration);
        }
    }
    */
    bool isRotate = false;
    public void WhenClicked()
    {
        animator.SetBool("isMoving", false);
        //isSelected = true;
        //isRotate = true;
        Canvas.SetActive(true);
        //StopCoroutine(MoveAndPauseRoutine()); // ������ �ڷ�ƾ �ߴ�

    }

    public void NotClicked()
    {
        animator.SetBool("isMoving", true);

        //isSelected = false;
        //isRotate = false;
        Canvas.SetActive(false);
        //StartCoroutine(MoveAndPauseRoutine()); // ������ �ڷ�ƾ �����

    }

    void Start()
    {
        Canvas.SetActive(false);

        animator = GetComponent<Animator>();
        animator.SetBool("isMoving", true);

        // StartCoroutine(MoveAndPauseRoutine()); 
    }
}
