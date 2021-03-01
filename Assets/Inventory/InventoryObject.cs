using UnityEngine;
[CreateAssetMenu (fileName = "InventoryItem", menuName = "Inventory/Item")]
public class InventoryObject : ScriptableObject
{
    [Header("Display")]
    [Tooltip("Offset when item on display")]
    [SerializeField] private Vector3 offsetDisplay = new Vector3(0.1f, 0.1f, 1.0f);
    [Tooltip("Offset maginitude to the left")]
    [Range(0.0f, 1.0f)]
    [SerializeField] private float offsetLeftDisplay = 0.1f;
    [Tooltip("Rotation towards you")]
    [Range(0.0f, 1.0f)]
    [SerializeField] private float rotation = 0.1f;
    [Tooltip("Scale on display")]
    [Range(0.0f, 1.0f)]
    [SerializeField] private float scale = 0.5f;

    public enum State
    {
        World = 0,
        Display = 1
    }

    public State state { get; private set; }
    private Transform target { get; set; }

    public GameObject prefab { get; private set; }
    public void Attach(GameObject gameObject)
    {
        this.prefab = gameObject;
        this.target = gameObject.transform;
        this.state = State.World;
    }

    public void AppendInventory()
    {
        InventorySystem.instance.Append(this);
        this.prefab.layer = 5;
        this.state = State.Display;
    }
    public void RemoveInventory()
    {
        InventorySystem.instance.Remove(this);
        //state = State.World;
    }

    public Transform Show(int i, Transform t, Camera c)
    {
        if (this.state == State.Display)
        {
            ShowCalculations(i, t, c);
        }
        return this.target;
    }

    private void ShowCalculations(int i, Transform t, Camera c)
    {
        this.target.position = c.ViewportToWorldPoint(new Vector3(offsetDisplay.x + offsetLeftDisplay * i, offsetDisplay.y, offsetDisplay.z));
        this.target.rotation = new Quaternion(0.0f, t.rotation.y, rotation, t.rotation.w);
        this.target.localScale = new Vector3(scale, scale, scale);
    }
}
