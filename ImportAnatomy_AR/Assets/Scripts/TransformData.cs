using Dummiesman;
using System.IO;
using UnityEngine;

public class TransformData : MonoBehaviour
{
    //���Ƿ� �� ��ȣ ���� 
    //�迭�� 0�� = Skin, 1�� = Heart

    //scale
    public float[,] orgScale = { { 968F, 3400F, 516F }, { 604F, 648F, 378F } }; //org model scale
    public float[,] mScale = { { 484.65F, 1700.9F, 258.33F }, { 302.15f, 324.03F, 189.75F } }; //unity model scale 


    //OrgPosition
    public float[,] Position = { { -242.325F, 850.45F, 129.165F }, { -233F, 1215F, 129F } };

    //rotation
    public float[,] Rotation = { { 90, 0, 0 }, { 90, 0, 0 } };



}
