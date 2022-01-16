using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(UIDocument))]
public class TestUI : MonoBehaviour
{
    UIDocument doc;

    // Start is called before the first frame update
    void Start()
    {
        doc = GetComponent<UIDocument>();
    }
}
