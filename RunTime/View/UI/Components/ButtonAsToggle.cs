using UnityEngine;
using UnityEngine.UI;

public class ButtonAsToggle : ValueContainer<bool>
{
    [SerializeField] private Button button;

    private void OnEnable()
    {
        if (button != null)
            button.onClick.AddListener(Toggle);
    }

    private void OnDisable()
    {
        if (button != null)
            button.onClick.RemoveListener(Toggle);
    }

    private void Toggle()
    {
        Value = !Value;
    }

    protected override void OnValueChanged()
    {
        base.OnValueChanged();
        Debug.Log($"Toggle state changed: {Value}");
    }
}