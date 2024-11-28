using UnityEngine;

namespace Task18
{
    public class GameContainer<T>
    {
        private T item;

        public void SetItem(T item)
        {
            this.item = item;
        }

        public T GetItem()
        {
            return item;
        }
    }


}
