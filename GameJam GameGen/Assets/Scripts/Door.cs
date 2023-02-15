using System.Collections;
using UnityEngine;

public class Door : MonoBehaviour
{
    private GameObject _player;

    public bool abierta;

    public float speed = 1f;

    public float rotationAmt = 90f;
    public float forwardDir = 0f;

    private Vector3 startRotation;
    private Vector3 forward;

    private Coroutine animCoroutine;

    private void Start()
    {
        _player = GameObject.Find("Player");

        startRotation = transform.rotation.eulerAngles;
        forward = transform.right;
    }

    private void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.F))
        {
            
            Vector3 a = new Vector3(transform.GetChild(0).transform.position.x, 0, transform.GetChild(0).transform.position.z);
            Vector3 b = new Vector3(_player.transform.position.x, 0, _player.transform.position.z);
            if (Vector3.Distance(a, b) < 4)
            {
                if (!abierta)
                {
                    Open();
                }
                else
                {
                    Close();
                }
            }
        }
    }

    public void Open()
    {
        if (!abierta)
        {
            if (animCoroutine != null)
            {
                StopCoroutine(animCoroutine);
            }

            float dot = Vector3.Dot(forward, (_player.transform.position - transform.position).normalized);
            animCoroutine = StartCoroutine(rotOpen(dot));
        }
    }

    private IEnumerator rotOpen(float dot)
    {
        Quaternion startRot = transform.rotation;
        Quaternion endRot;

        if (dot >= forwardDir)
        {
            endRot = Quaternion.Euler(new Vector3(0, startRotation.y - rotationAmt, 0));
        }
        else
        {
            endRot = Quaternion.Euler(new Vector3(0, startRotation.y + rotationAmt, 0));
        }

        abierta = true;
        float time = 0;
        while (time < 1)
        {
            transform.rotation = Quaternion.Slerp(startRot, endRot, time);
            yield return null;
            time += Time.deltaTime * speed;
        }
    }

    public void Close()
    {
        if (abierta)
        {
            if (animCoroutine != null)
            {
                StopCoroutine(animCoroutine);
            }

            animCoroutine = StartCoroutine(rotClose());
        }
    }

    private IEnumerator rotClose()
    {
        Quaternion startRot = transform.rotation;
        Quaternion endRot = Quaternion.Euler(startRotation);

        abierta = false;
        float time = 0;
        while (time < 1)
        {
            transform.rotation = Quaternion.Slerp(startRot, endRot, time);
            yield return null;
            time += Time.deltaTime * speed;
        }
    }
}