using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Получить одну сущность
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        string GetItem(int? id);

        /// <summary>
        /// Получить все сущности
        /// </summary>
        /// <returns></returns>
        string GetAll();

        /// <summary>
        /// Создать сущность в БД
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        string Create(T item);

        /// <summary>
        /// Обновить сущность в БД
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        string Update(T item);

        /// <summary>
        /// Удалить сущность из БД
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        string Remove(T item);
    }
}
