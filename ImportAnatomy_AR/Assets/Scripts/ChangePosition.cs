using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePosition : MonoBehaviour
{
    public Slider slider;
    public Transform objectTransform;
    public Transform planeTransform;
    public Renderer planeRenderer;
    private Vector3 position1 = new Vector3(-237, 2702, 136);
    private Vector3 position2 = new Vector3(-237, 1000, 136);

    private void Start()
    {
        objectTransform.position = new Vector3(-237, 2702, 136); //ó�� ����ũ ��ġ
        planeTransform.position = new Vector3(-237, 1702, 136); //plane ��ġ
        // Make sure the slider value is clamped between 0 and 1
        slider.onValueChanged.AddListener(UpdatePosition);
    }

    public void UpdatePosition(float value)
    {
        Vector3 newPosition = Vector3.Lerp(position1, position2, value);
        objectTransform.position = newPosition;
        planeTransform.position = new Vector3(-237, objectTransform.position.y - 1000, 136);
        int planePosY = (1702 - (int)(objectTransform.position.y - 1000) - 1) * 5;
        string fmt = "0000";
        string Texnum = planePosY.ToString(fmt);
        Texture2D texture = Resources.Load<Texture2D>("Textures/" + Texnum);
        planeRenderer.material.mainTexture = texture;
    }
}
