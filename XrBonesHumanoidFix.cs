using UnityEngine;
using UnityEditor;

/// <summary>
/// Класс для исправления костей Гуманоидов
/// </summary>
public class XrBonesHumanoidFix : MonoBehaviour
{
    /// <summary>
    /// Исправление кости ноги
    /// </summary>
    /// <param name="value">Править ли ногу ?</param>
    /// <param name="angle">Угол поворота стопы</param>
    public void StartFix(bool value, float angle)
    {
        GameObject bip1_l_toe = GameObject.Find("bip01_l_toe0");

        GameObject r_finger_1 = GameObject.Find("bip01_r_finger02");
        GameObject r_finger_2 = GameObject.Find("bip01_r_finger12");
        GameObject r_finger_3 = GameObject.Find("bip01_r_finger22");
        GameObject r_finger_4 = GameObject.Find("bip01_r_finger32");

        GameObject l_finger_1 = GameObject.Find("bip01_l_finger02");
        GameObject l_finger_2 = GameObject.Find("bip01_l_finger12");
        GameObject l_finger_3 = GameObject.Find("bip01_l_finger22");
        GameObject l_finger_4 = GameObject.Find("bip01_l_finger32");


        if (r_finger_1 != null) r_finger_1.transform.localEulerAngles = Vector3.zero;
        if (r_finger_2 != null) r_finger_2.transform.localEulerAngles = Vector3.zero;
        if (r_finger_3 != null) r_finger_3.transform.localEulerAngles = Vector3.zero;
        if (r_finger_4 != null) r_finger_4.transform.localEulerAngles = Vector3.zero;

        if (l_finger_1 != null) l_finger_1.transform.localEulerAngles = Vector3.zero;
        if (l_finger_2 != null) l_finger_2.transform.localEulerAngles = Vector3.zero;
        if (l_finger_3 != null) l_finger_3.transform.localEulerAngles = Vector3.zero;
        if (l_finger_4 != null) l_finger_4.transform.localEulerAngles = Vector3.zero;

        if (bip1_l_toe != null && value) bip1_l_toe.transform.localEulerAngles = new Vector3(angle, -90f, 0f);

        Debug.Log("Fix bones!");

    }
}
