using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int scoreValue; // ��ṹ�������
    Text score; // UI ����Ѻ�ʴ���ṹ

    // �ѧ��ѹ����Ѻ������ṹ
    void Start()
    {
        score = GetComponent<Text>();
    }

    // �ѧ��ѹ����Ѻ�Ѿഷ��ͤ���� UI
    void Update()
    {
        score.text = "Score: " + scoreValue;
    }
}
