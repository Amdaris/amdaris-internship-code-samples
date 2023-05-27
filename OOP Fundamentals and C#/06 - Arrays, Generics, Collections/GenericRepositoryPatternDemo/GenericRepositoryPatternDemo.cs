using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace GenericRepositoryPatternDemo
{
    public abstract class Entity
    {
        public int Id { get; set; }
    }

    public class Book : Entity
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public string ISBN { get; set; }

        public decimal Price { get; set; }

        public int ItemsInStock { get; set; }
    }

    public class Customer : Entity
    {
        public string Email { get; set; }
        public decimal Balance { get; set; }
    }

    public interface IRepository<T> where T : Entity
    {
        T GetById(int id);
        IList<T> FindAll();

        void Add(T entity);

        void Delete(T entity);

        void Update(T entity);
    }


    public class Shop
    {
        private readonly IRepository<Book> _bookRepository;
        private readonly IRepository<Customer> _customerRepository;

        public Shop(IRepository<Book> bookRepository, IRepository<Customer> customerRepository)
        {
            _bookRepository = bookRepository;
            _customerRepository = customerRepository;
        }

        public bool PurchaseBook(int customerId, int bookId)
        {
            Customer customer = _customerRepository.GetById(customerId);

            if (customer == null)
            {
                Console.WriteLine($"Customer with id {customerId} was not found!");
                return false;
            }

            Book book = _bookRepository.GetById(bookId);

            if (book == null)
            {
                Console.WriteLine($"Book with id {bookId} was not found!");
                return false;
            }

            if (book.ItemsInStock == 0)
            {
                Console.WriteLine($"There are no books `{book.Title}` in stock!");
                return false;
            }

            if (customer.Balance < book.Price)
            {
                Console.WriteLine($"Customer does not have enough money to buy the book {book.Title}");
                return false;
            }

            customer.Balance -= book.Price;
            book.ItemsInStock--;

            _customerRepository.Update(customer);
            _bookRepository.Update(book);

            Console.WriteLine($"Book `{book.Title}` successfully purchased by {customer.Email}");

            return true;
        }
    }

    public class GenericRepositoryPatternDemo
    {
        public static void Main(string[] args)
        {
            IRepository<Book> bookRepository = new ListRepository<Book>();
            IRepository<Customer> customerRepository = new ListRepository<Customer>();

            bookRepository.Add(new Book { Id = 1, Author = "Tolkien", Title = "Lord of the Rings", Price = 250, ItemsInStock = 2 });
            bookRepository.Add(new Book { Id = 2, Author = "Martin", Title = "A Song of Ice and Fire", Price = 250, ItemsInStock = 0 });
            bookRepository.Add(new Book { Id = 3, Author = "Lewis", Title = "The Chroniclesof Narnia", Price = 900, ItemsInStock = 1 });

            Customer customer = new Customer { Id = 1, Email = "peter.brown@email.com", Balance = 1000 };
            customerRepository.Add(customer);

            Shop shop = new Shop(bookRepository, customerRepository);
            shop.PurchaseBook(1, 1);
            shop.PurchaseBook(1, 2);
            shop.PurchaseBook(1, 3);
        }
    }


    public class ListRepository<T> : IRepository<T> where T : Entity
    {
        private readonly List<T> _entities = new List<T>();

        public void Add(T entity)
        {
            _entities.Add(entity);
        }

        public IList<T> FindAll()
        {
            return new List<T>(_entities);
        }

        public T GetById(int id)
        {
            foreach (T entity in _entities)
            {
                if (entity.Id == id)
                    return entity;
            }

            return null;
        }

        public void Delete(T entity)
        {
            _entities.Remove(entity);
        }

        public void Update(T entity)
        {
            T storedEntity = GetById(entity.Id);
            if (storedEntity != null)
            {
                _entities.Remove(storedEntity);
            }
            _entities.Add(entity);
        }
    }
}