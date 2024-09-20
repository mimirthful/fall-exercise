using UnityEngine;
using TMPro;

public class Uwon : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI text;

    
    private void OnCollisionEnter2D(Collision2D other)
    {
        text.text = "You Win!";
    }
}
