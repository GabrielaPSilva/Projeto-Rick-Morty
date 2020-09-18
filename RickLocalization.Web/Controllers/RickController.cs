using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using RickLocalization.Data.Entities;
using RickLocalization.Data.Interfaces;
using RickLocalization.Web.Models;

namespace RickLocalization.Web.Controllers
{
    public class RickController : Controller
    {
        private readonly IRickRepository _rickRepository;
        private readonly ITripRepository _tripRepository;
        private readonly IMapper _mapper;

        public RickController(IRickRepository rickRepository, IMapper mapper, IMortyRepository mortyRepository, ITripRepository tripRepository)
        {
            _rickRepository = rickRepository;
            _tripRepository = tripRepository;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var lista = _mapper.Map<List<RickViewModel>>(_rickRepository.List());
            return View(lista);
        }

        public ActionResult Detalhes (int Id, string Dimensao)
        {
            var retorno = _mapper.Map<RickViewModel>(_rickRepository.GetById(Id));
            return View(retorno); 
        }

        public ActionResult Historico(int IdRick)
        {
            var trips = _mapper.Map<List<TripViewModel>>(_tripRepository.List().Where(trip => trip.IdRick == IdRick));
            //var retorno = (_mapper.Map<TripViewModel>(new TripViewModel()
            //{
            //    IdRick = ricky.Id,
            //    IdDimensao = ricky.IdDimensao,
            //    Id = trip.Id,
            //    Descricao = trip.Descricao
            //}));
            return View(trips);
        }

        [HttpPost]
        public ActionResult ProcessarDados(TripViewModel tripViewModel)
        {
            _tripRepository.Add(_mapper.Map<Trip>(new TripViewModel() { IdRick = tripViewModel.IdRick, IdDimensao = tripViewModel.IdDimensao, Descricao = tripViewModel.Descricao }));

            
            return Redirect("Index");
        }
    }
}
