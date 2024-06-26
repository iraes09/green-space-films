﻿using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ProyectoGreenSpace.Classes
{
    internal class Ticket
    {
        private int id;
        private int userId;
        private int filmId;
        private int roomId;
        private DateTime dateBought;
        private DateTime dateFilm;
        private int quantity;
        private double totalPrice;
        private double discount;

        public DateTime DateBought { get { return dateBought; } }
        public DateTime DateFilm { get { return dateFilm; } }
        public int Quantity { get { return quantity; } }
        public double TotalPrice { get { return totalPrice; } }
        public double Discount { get { return discount; } }

        public Ticket(int userId, int filmId, int roomId, DateTime dateBought, DateTime dateFilm, int quantity, double totalPrice, double discount)
        {
            this.userId = userId;
            this.filmId = filmId;
            this.roomId = roomId;
            this.dateBought = dateBought;
            this.dateFilm = dateFilm;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
            this.discount = discount;
        }

        public Ticket(int id, int userId, int filmId, int roomId, DateTime dateBought, DateTime dateFilm, int quantity, double totalPrice, double discount)
        {
            this.id = id;
            this.userId = userId;
            this.filmId = filmId;
            this.roomId = roomId;
            this.dateBought = dateBought;
            this.dateFilm = dateFilm;
            this.quantity = quantity;
            this.totalPrice = totalPrice;
            this.discount = discount;
        }

        /// <summary>
        /// Obtiene el usuario del ticket
        /// </summary>
        /// <returns>Un objeto usuario</returns>
        public User getUser()
        {
            return User.InfoUser(userId);
        }

        /// <summary>
        /// Obtiene la pelicula del ticket
        /// </summary>
        /// <returns>Un objeto pelicula</returns>
        public Film getFilm()
        {
            return Film.InfoFilm(filmId);
        }

        /// <summary>
        /// Obtiene la sala del ticket
        /// </summary>
        /// <returns>Un objeto sala</returns>
        public Room getRoom()
        {
            return Room.InfoRoom(roomId);
        }

        /// <summary>
        /// Inserts the Ticket into the Database
        /// </summary>
        public void Create()
        {
            string query = "INSERT INTO tickets (userId, filmId, roomId, dateBought, dateFilm, quantity, total_price, discount) VALUES (@userId, @filmId, @roomId, @dateBought, @dateFilm, @quantity, @totalPrice, @discount)";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@filmId", filmId);
            command.Parameters.AddWithValue("@roomId", roomId);
            command.Parameters.AddWithValue("@dateBought", dateBought);
            command.Parameters.AddWithValue("@dateFilm", dateFilm);
            command.Parameters.AddWithValue("@totalPrice", totalPrice);
            command.Parameters.AddWithValue("@discount", discount);

            ConnectionBD.OpenConnection();

            command.ExecuteNonQuery();

            ConnectionBD.CloseConnection();
        }

        /// <summary>
        /// Obtiene un ticket de la base de datos en base a su ID
        /// </summary>
        /// <param name="id">El ID del ticket</param>
        /// <returns>Un objeto ticket</returns>
        public static Ticket Obtain(int id)
        {
            string query = "SELECT * FROM tickets WHERE id LIKE @id";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@id", id);

            Ticket ticket = null;

            ConnectionBD.OpenConnection();
            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    ticket = new Ticket(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        reader.GetInt32(6),
                        reader.GetDouble(7),
                        reader.GetDouble(8)
                    );
                }
            }
            ConnectionBD.CloseConnection();
            return ticket;
        }

        /// <summary>
        /// Recupera todos los tickets de un usuario
        /// </summary>
        /// <param name="userId">El ID del usuario</param>
        /// <returns>Lista con todos los tickets</returns>
        public static List<Ticket> Tickets(int userId)
        {
            List<Ticket> tickets = new List<Ticket>();

            string query = "SELECT * FROM tickets WHERE userId = @userId";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    tickets.Add(new Ticket(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        reader.GetInt32(6),
                        reader.GetDouble(7),
                        reader.GetDouble(8)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return tickets;
        }

        /// <summary>
        /// Recupera todos los tickets de un usuario de las peliculas que todavia no han pasado la fecha de visualizacion
        /// </summary>
        /// <param name="userId">El ID del usuario</param>
        /// <returns>Lista con todos los tickets</returns>
        public static List<Ticket> ActualTickets(int userId)
        {
            List<Ticket> tickets = new List<Ticket>();

            string query = "SELECT * FROM tickets WHERE userId = @userId AND dateFilm >= @date";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    tickets.Add(new Ticket(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        reader.GetInt32(6),
                        reader.GetDouble(7),
                        reader.GetDouble(8)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return tickets;
        }

        /// <summary>
        /// Recupera todos los tickets de un usuario de las peliculas que ya han pasado la fecha de visualizacion
        /// </summary>
        /// <param name="userId">El ID del usuario</param>
        /// <returns>Lista con todos los tickets</returns>
        public static List<Ticket> PastTickets(int userId)
        {
            List<Ticket> tickets = new List<Ticket>();

            string query = "SELECT * FROM tickets WHERE userId = @userId AND dateFilm < @date";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

            ConnectionBD.OpenConnection();

            using (MySqlDataReader reader = command.ExecuteReader()) // Abrir y cerrar la conexión del dataReader --> Tabla virtual
            {
                while (reader.Read())
                {
                    tickets.Add(new Ticket(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetDateTime(4),
                        reader.GetDateTime(5),
                        reader.GetInt32(6),
                        reader.GetDouble(7),
                        reader.GetDouble(8)
                    ));
                }
            }

            ConnectionBD.CloseConnection();

            return tickets;
        }

        /// <summary>
        /// Obtiene la cantidad de tickets actuales que tiene un usuario
        /// </summary>
        /// <param name="userId">El ID del usuario</param>
        /// <returns>Cantidad de tickets</returns>
        public static int AmountActualTickets(int userId)
        {
            string query = "SELECT COUNT(*) FROM tickets WHERE userId = @userId AND dateFilm >= @date";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

            ConnectionBD.OpenConnection();

            int amount = Convert.ToInt32(command.ExecuteScalar());

            ConnectionBD.CloseConnection();

            return amount;
        }

        /// <summary>
        /// Obtiene la cantidad de tickets pasados que tiene un usuario
        /// </summary>
        /// <param name="userId">El ID del usuario</param>
        /// <returns>Cantidad de tickets</returns>
        public static int AmountPastTickets(int userId)
        {
            string query = "SELECT COUNT(*) FROM tickets WHERE userId = @userId AND dateFilm < @date";

            MySqlCommand command = new MySqlCommand(query, ConnectionBD.Connection);
            command.Parameters.AddWithValue("@userId", userId);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString("yyyy-MM-dd"));

            ConnectionBD.OpenConnection();

            int amount = Convert.ToInt32(command.ExecuteScalar());

            ConnectionBD.CloseConnection();
            
            return amount;
        }
    }
}