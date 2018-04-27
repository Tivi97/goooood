using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.ManagedDataAccess.Client;
using System.Web.Mvc;

namespace Library.Models.Books
{
    public class BooksModel:Model
    {
        public List<SelectListItem> GetBookList()
        {
            using (Connection)
            {
                Connection.Open();
                var adapter = new OracleDataAdapter
                {
                    SelectCommand = new OracleCommand
                    {
                        Connection = Connection,
                        CommandText = "select book_name, authors_surname, authors_name, AUTHORS_PATRONYMIC, name_rubric, method_issuing from books, authors, books_rubric where books.id_author=authors.id_author and books_rubric.id_rubric=books.id_rubric"
                    }
                };
                var reader = adapter.SelectCommand.ExecuteReader();
                var list = new List<SelectListItem>();
                while (reader.Read())
                {
                    var book_ = new SelectListItem
                    {
                        Value = reader["id_book"].ToString(),
                        Text = reader["book_name"].ToString()
                    };
                    list.Add(book_);
                }
                Connection.Close();
                return list;
            }
        }

       
    }
}