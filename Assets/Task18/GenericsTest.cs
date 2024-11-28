using UnityEngine;

namespace Task18
{

    public class GenericsTest : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            GameContainer<string> container = new GameContainer<string>();
            container.SetItem("Healing Potion");

            string item = container.GetItem();
            Debug.Log($"Stored item: {item}");

            string description = GameUtils.DescribeItem(item);
            Debug.Log(description);

        }


    }

}
