using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catapult : MonoBehaviour
{
    [SerializeField] LineRenderer lineRender;
    [SerializeField] GameObject ball;
    ball currentBall;
    bool isAiming;

    // Start is called before the first frame update
    void Start()
    {
        lineRender.enabled = false;
        ball.SetActive(false);
    }

    // Update is called once per frame
    private void OnMouseDown()
    {
        currentBall = Instantiate(ball, controller.instance.MousePos, Quaternion.identity).GetComponent<ball>();
        currentBall.gameObject.SetActive(true);

        lineRender.enabled = true;
        isAiming = true;
    }

    private void Update()
    {
        if (isAiming)
        {
            lineRender.SetPosition(0, this.transform.position);

            Vector2 _aimPos = (Vector2)transform.position + Vector2.ClampMagnitude(controller.instance.MousePos - (Vector2)transform.position, 5f);
            //Debug.Log("down");
            lineRender.SetPosition(1, _aimPos);

            currentBall.transform.position = _aimPos;
            //Debug.Log(currentBall.transform.position);
            //Debug.Log("test");

            if (Input.GetMouseButtonUp(0))
            {
                currentBall.Shoot(((Vector2)transform.position - _aimPos).normalized, Vector2.SqrMagnitude((Vector2)transform.position - _aimPos));

                currentBall = null;
                lineRender.enabled = false;
                isAiming = false;
                //Debug.Log("released");
            }
        }
    }
}
