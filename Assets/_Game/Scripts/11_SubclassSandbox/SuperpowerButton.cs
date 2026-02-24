using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace SubclassSandbox
{
    [RequireComponent(typeof(Button))]
    public class SuperpowerButton : MonoBehaviour
    {
        [SerializeField]
        private Superpower _superpower;
        private void Awake()
        {
           GetComponent<Button>().onClick.AddListener(OnButtonClick);
        }

        private void OnButtonClick()
        {
            _superpower.Activate();
        }
    }
}