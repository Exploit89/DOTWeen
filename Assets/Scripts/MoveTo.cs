using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoveTo : MonoBehaviour
{
    private void Start()
    {
        transform.DOMove(new Vector3(0, 5, 0), 3); // �������� �� �����
        //transform.DOMove(new Vector3(0, 5, 0), 3).From(); // �������� �� �����
        //transform.DOMove(new Vector3(0, 5, 0), 3).SetDelay(2); // �������� � ���������� �������
        //transform.DOMove(new Vector3(0, 5, 0), 3).SetLoops(-1, LoopType.Restart); // -1 ��� ����������� ���� ����� - ��� ����� ����������
    }
}
