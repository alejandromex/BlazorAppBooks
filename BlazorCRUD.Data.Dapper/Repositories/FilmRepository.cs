using BlazorCRUD.Model;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace BlazorCRUD.Data.Dapper.Repositories
{
    public class FilmRepository : IFilmRepository
    {
        private string ConnectionString;
        public FilmRepository(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        protected SqlConnection dbConnection()
        {
            return new SqlConnection(ConnectionString);
        }

        public Task<bool> DeleteFilm(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Film>> GetAllFilms()
        {
            var db = dbConnection();
            var sql = @"SELECT * FROM films";
            return await db.QueryAsync<Film>(sql.ToString(), new { });
        }

        public async Task<Film> GetFilmDetails(int id)
        {
            var db = dbConnection();
            var sql = @"SELECT * FROM films where id = @id";
            var film = await db.QueryFirstOrDefaultAsync<Film>(sql, new { id });
            return film;
        }

        public async Task<bool> InsertFilm(Film film)
        {
            var db = dbConnection();
            var sql = @"
                        INSERT INTO films (title, Director, ReleaseDate) 
                        VALUES (@Title, @Director, @ReleaseDate)
                        ";
            var result = await db.ExecuteAsync(sql.ToString(), new { film.Title, film.Director, film.ReleaseDate });

            return result > 0;
        }

        public async Task<bool> UpdateFilm(Film film)
        {
            var db = dbConnection();
            var sql = @"
                        UPDATE films set title = @title, Director = @Director, ReleaseDate = @ReleaseDate where id = @id
                        ";
            var result = await db.ExecuteAsync(sql.ToString(), new { film.Title, film.Director, film.ReleaseDate, film.id });
            return result > 0;
        }
    }
}
