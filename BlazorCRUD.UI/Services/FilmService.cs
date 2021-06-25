using BlazorCRUD.Data.Dapper.Repositories;
using BlazorCRUD.Model;
using BlazorCRUD.UI.Data;
using BlazorCRUD.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Services
{
    public class FilmService : IFilmService
    {
        private readonly SqlConfiguration _configuration;
        private IFilmRepository _filmRepository;
        public FilmService(SqlConfiguration configuration)
        {
            this._configuration = configuration;
            this._filmRepository = new FilmRepository(_configuration.ConnectionString);
        }


        public Task<bool> DeleteFilm(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Film>> GetAllFilms()
        {
            throw new NotImplementedException();
        }

        public Task<Film> GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> SaveFilm(Film film)
        {
            if(film.id == 0)
            {
                return _filmRepository.InsertFilm(film);
            }
            else
            {
                return null;
                //return _filmRepository.UpdateFilm(film);
            }
        }
    }
}
