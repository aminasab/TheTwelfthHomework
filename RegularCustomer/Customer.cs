using System.Collections.Specialized;

namespace RegularCustomer
{
    internal class Customer
    {
        private Shop? _shop;

        /// <summary>
        /// Подписка на событие.
        /// </summary>
        public void Subscribe(Shop shop)
        {
            _shop = shop;
            _shop.Items.CollectionChanged += Items_CollectionChanged;
        }

        private void Items_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    var newItem = (Item?)e.NewItems?[^1];
                    Console.WriteLine($"Добавлен товар: {newItem!.Name}, с Id = {newItem.Id}");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    var oldItem = (Item?)e.OldItems?[0];
                    Console.WriteLine($"Удален товар: {oldItem!.Name}, с Id = {oldItem.Id}") ;
                    break;
            }
        }
    }
}
