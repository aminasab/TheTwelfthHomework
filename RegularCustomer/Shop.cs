using System.Collections.ObjectModel;

namespace RegularCustomer
{
    internal class Shop
    {
        public readonly ObservableCollection<Item> Items=new();
        int _lastIndex;

        /// <summary>
        /// Добавление нового товара.
        /// </summary>
        public void Add(string nameOfItem)
        {
            ++_lastIndex;
            Items.Add(new Item(_lastIndex,nameOfItem));
        }

        /// <summary>
        /// Удаление товара.
        /// </summary>
        public void Remove(int removeIdItem)
        {
            var itemForDelete = Items.Where(i => i.Id == removeIdItem).ToList();
            foreach (var item in itemForDelete)
            {
                Items.Remove(item);
            }
        }
    }
}
