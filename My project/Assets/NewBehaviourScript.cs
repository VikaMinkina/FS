using UnityEngine;

public class SetActiveObj : MonoBehaviour
{

    public GameObject obj;

    public void ClickButton()
    {
        if (obj.activeSelf)
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);
        }
    }
}
